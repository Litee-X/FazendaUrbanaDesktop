using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Util.BD;

namespace FazendaUrbanaDesktop.ModuloCliente
{
    public partial class frmGerenciarCliente : Form
    {
        private readonly ConexaoBanco _factory;

        public frmGerenciarCliente(ConexaoBanco factory)
        {
            InitializeComponent();
            _factory = factory;
            CarregarClientes(); // Carrega os clientes ao inicializar o formulário
        }

        private void frmGerenciarCliente_Load(object sender, EventArgs e)
        {
            dgGerenciarCliente.ReadOnly = true;
            dgGerenciarCliente.AllowUserToAddRows = false;
            dgGerenciarCliente.AllowUserToDeleteRows = false;
            dgGerenciarCliente.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgGerenciarCliente.MultiSelect = false;
            dgGerenciarCliente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        // Função para carregar todos os clientes
        private void CarregarClientes()
        {
            try
            {
                var gerenciarClientes = new GerenciarCliente();
                DataTable tabelaClientes = gerenciarClientes.ObterTodosClientes(_factory);
                dgGerenciarCliente.DataSource = tabelaClientes;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar clientes: " + ex.Message);
            }
        }

        // Função para preencher os campos quando a linha for selecionada no DataGridView
        private void dgGerenciarCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgGerenciarCliente.Rows[e.RowIndex];
                PreencherCampos(row);
            }
        }

        // Função para preencher os campos de texto com os dados da linha selecionada
        private void PreencherCampos(DataGridViewRow row)
        {
            txtNome.Text = row.Cells["nome"].Value.ToString();
            txtEmail.Text = row.Cells["email"].Value.ToString();
            mskCnpj.Text = row.Cells["cnpj"].Value.ToString();
            txtEndereco.Text = row.Cells["endereco"].Value.ToString();
        }

        // Botão de cadastrar cliente
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(txtNome.Text) &&
                    !string.IsNullOrWhiteSpace(txtEmail.Text) &&
                    !string.IsNullOrWhiteSpace(mskCnpj.Text) &&
                    !string.IsNullOrWhiteSpace(txtEndereco.Text))
                {
                    var cadCliente = new GerenciarCliente
                    {
                        Nome = txtNome.Text,
                        Email = txtEmail.Text,
                        Cnpj = mskCnpj.Text,
                        Endereco = txtEndereco.Text
                    };

                    if (cadCliente.CadastrarCliente(_factory))
                    {
                        MessageBox.Show($"O cliente {cadCliente.Nome} foi cadastrado com sucesso!");
                        LimparCampos();
                        CarregarClientes();
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível cadastrar o cliente!");
                    }
                }
                else
                {
                    MessageBox.Show("Favor preencher todos os campos corretamente!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar cliente: " + ex.Message);
            }
        }

        // Botão de atualizar cliente
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgGerenciarCliente.SelectedRows.Count > 0)
                {
                    // Obter dados da linha selecionada no DataGridView
                    var linha = dgGerenciarCliente.SelectedRows[0];
                    string cnpj = linha.Cells["cnpj"].Value.ToString(); // Pega o CNPJ da linha selecionada

                    // Recuperar valores dos campos para atualização
                    string nome = string.IsNullOrWhiteSpace(txtNome.Text) ? linha.Cells["nome"].Value.ToString() : txtNome.Text;
                    string email = string.IsNullOrWhiteSpace(txtEmail.Text) ? linha.Cells["email"].Value.ToString() : txtEmail.Text;
                    string endereco = string.IsNullOrWhiteSpace(txtEndereco.Text) ? linha.Cells["endereco"].Value.ToString() : txtEndereco.Text;

                    var clienteAtualizar = new GerenciarCliente
                    {
                        Cnpj = cnpj,
                        Nome = nome,
                        Email = email,
                        Endereco = endereco
                    };

                    // Tentar atualizar o cliente no banco de dados
                    if (clienteAtualizar.AtualizarCliente(_factory))
                    {
                        MessageBox.Show("Os dados do cliente foram atualizados com sucesso!");
                        LimparCampos();
                        CarregarClientes(); // Recarrega a lista de clientes
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível atualizar as informações do cliente.");
                    }
                }
                else
                {
                    MessageBox.Show("Selecione um cliente para atualizar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao atualizar dados do cliente: {ex.Message}");
            }
        }

        // Botão de deletar cliente
        private void btnDeletar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgGerenciarCliente.SelectedRows.Count > 0)
                {
                    var linha = dgGerenciarCliente.SelectedRows[0];
                    string cnpj = linha.Cells["cnpj"].Value.ToString(); // Pega o CNPJ da linha selecionada

                    var clienteDeletar = new GerenciarCliente
                    {
                        Cnpj = cnpj
                    };

                    // Tentar deletar o cliente
                    if (clienteDeletar.DeletarCliente(_factory))
                    {
                        MessageBox.Show("O cliente foi excluído com sucesso!");
                        LimparCampos();
                        CarregarClientes(); // Recarrega a lista de clientes
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível excluir o cliente.");
                    }
                }
                else
                {
                    MessageBox.Show("Selecione um cliente para excluir.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao excluir cliente: {ex.Message}");
            }
        }

        // Função para limpar os campos de texto
        private void LimparCampos()
        {
            txtNome.Clear();
            txtEmail.Clear();
            mskCnpj.Clear();
            txtEndereco.Clear();
            mskCnpj.Focus(); // Foca no campo CNPJ após limpar
        }

        // Evento de pesquisa, que atualiza os clientes no DataGridView conforme a digitação
   
        private void txtPesquisa_TextChanged_1(object sender, EventArgs e)
        {
            string pesquisa = txtPesquisa.Text;
            using (SqlConnection conn = _factory.ObterConexao())
            {
                conn.Open();
                string query = "SELECT nome, cnpj, email, endereco FROM Cliente WHERE nome LIKE @pesquisa OR cnpj LIKE @pesquisa";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@pesquisa", $"%{pesquisa}%");
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgGerenciarCliente.DataSource = dt; // Atualiza o DataGridView com os resultados da pesquisa
                }
            }
        }
    }
}
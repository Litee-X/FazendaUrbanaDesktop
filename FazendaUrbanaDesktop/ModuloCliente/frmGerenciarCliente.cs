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
            // Configurações do DataGridView
            dgGerenciarCliente.ReadOnly = true; // Define o DataGridView como somente leitura
            dgGerenciarCliente.AllowUserToAddRows = false; // Impede a adição de novas linhas
            dgGerenciarCliente.AllowUserToDeleteRows = false; // Impede a exclusão de linhas
            dgGerenciarCliente.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Seleciona a linha inteira
            dgGerenciarCliente.MultiSelect = false; // Desabilita a seleção de múltiplas linhas
            dgGerenciarCliente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Preenche todo o espaço disponível
        }

        // Função para carregar todos os clientes
        private void CarregarClientes()
        {
            try
            {
                var gerenciarClientes = new GerenciarCliente();
                DataTable tabelaClientes = gerenciarClientes.ObterTodosClientes(_factory);
                dgGerenciarCliente.DataSource = tabelaClientes; // Preenche o DataGridView com os clientes
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar clientes: " + ex.Message);
            }
        }

        // Função para carregar a seleção da linha no DataGridView para os campos
        private void dgGerenciarCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Verifica se a linha clicada é válida
            {
                var row = dgGerenciarCliente.Rows[e.RowIndex];
                PreencherCampos(row); // Preenche os campos com os dados da linha selecionada
            }
        }

        // Função para preencher os campos de texto com os dados da linha selecionada
        private void PreencherCampos(DataGridViewRow row)
        {
            lblId.Text = row.Cells["id"].Value.ToString();
            txtNome.Text = row.Cells["nome"].Value.ToString();
            txtEmail.Text = row.Cells["email"].Value.ToString();
            mskCnpj.Text = row.Cells["cnpj"].Value.ToString();
            txtEndereco.Text = row.Cells["endereco"].Value.ToString(); // Preenchendo o endereço
        }

        // Botão de cadastrar cliente
        private void btnCadastrar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(txtNome.Text) &&
                    !string.IsNullOrWhiteSpace(txtEmail.Text) &&
                    !string.IsNullOrWhiteSpace(mskCnpj.Text) &&
                    !string.IsNullOrWhiteSpace(txtEndereco.Text)) // Verificando endereço
                {
                    var cadCliente = new GerenciarCliente
                    {
                        Nome = txtNome.Text,
                        Email = txtEmail.Text,
                        Cnpj = mskCnpj.Text,
                        Endereco = txtEndereco.Text // Adicionando endereço
                    };

                    // Chama o método para cadastrar
                    if (cadCliente.CadastrarCliente(_factory))
                    {
                        MessageBox.Show($"O cliente {cadCliente.Nome} foi cadastrado com sucesso!");
                        LimparCampos(); // Limpa os campos após cadastrar
                        CarregarClientes(); // Recarrega a lista de clientes
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
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(mskCnpj.Text) &&
                    !string.IsNullOrWhiteSpace(txtEmail.Text) &&
                    !string.IsNullOrWhiteSpace(txtNome.Text) &&
                    !string.IsNullOrWhiteSpace(txtEndereco.Text)) // Verificando endereço
                {
                    var clienteAtualizar = new GerenciarCliente
                    {
                        Id = int.Parse(lblId.Text),
                        Nome = txtNome.Text,
                        Email = txtEmail.Text,
                        Cnpj = mskCnpj.Text,
                        Endereco = txtEndereco.Text // Atualizando endereço
                    };

                    // Chama o método de atualização
                    if (clienteAtualizar.AtualizarCliente(_factory))
                    {
                        MessageBox.Show("Os dados do cliente foram atualizados com sucesso!");
                        LimparCampos(); // Limpa os campos após atualizar
                        CarregarClientes(); // Recarrega a lista de clientes
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível atualizar as informações do cliente");
                    }
                }
                else
                {
                    MessageBox.Show("Favor localizar o cliente que deseja atualizar as informações");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar dados do cliente: " + ex.Message);
            }
        }

        // Botão de deletar cliente
        private void btnDeletar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (dgGerenciarCliente.SelectedRows.Count > 0) // Verifica se há uma linha selecionada
                {
                    // Obtém o CNPJ do cliente selecionado
                    var linha = dgGerenciarCliente.SelectedRows[0];
                    string cnpj = linha.Cells["cnpj"].Value.ToString(); // Captura o CNPJ do cliente

                    var clienteDeletar = new GerenciarCliente
                    {
                        Cnpj = cnpj // Usar CNPJ para deletar
                    };

                    // Chama o método de exclusão
                    if (clienteDeletar.DeletarCliente(_factory))
                    {
                        MessageBox.Show("O cliente foi excluído com sucesso!");
                        LimparCampos(); // Limpa os campos após deletar
                        CarregarClientes(); // Recarrega a lista de clientes
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível excluir o cliente");
                    }
                }
                else
                {
                    MessageBox.Show("Selecione um cliente para excluir.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir cliente: " + ex.Message);
            }
        }

        // Função para limpar os campos de texto
        private void LimparCampos()
        {
            mskCnpj.Clear();
            txtEmail.Clear();
            txtNome.Clear();
            txtEndereco.Clear(); // Limpando o campo de endereço
            lblId.Text = "";
            mskCnpj.Focus();
        }

        // Botão de pesquisar cliente
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(mskCnpj.Text) || !string.IsNullOrWhiteSpace(txtNome.Text)) // Permitir pesquisa por CNPJ ou Nome
                {
                    var cliente = new GerenciarCliente
                    {
                        Cnpj = mskCnpj.Text,
                        Nome = txtNome.Text // Permitindo pesquisa por nome
                    };

                    // Chama o método de localização
                    using (SqlDataReader reader = cliente.LocalizarCliente(_factory))
                    {
                        if (reader != null && reader.HasRows)
                        {
                            reader.Read();
                            lblId.Text = reader["id"].ToString();
                            txtNome.Text = reader["nome"].ToString();
                            txtEmail.Text = reader["email"].ToString();
                            mskCnpj.Text = reader["cnpj"].ToString();
                            txtEndereco.Text = reader["endereco"].ToString(); // Preenchendo o endereço
                        }
                        else
                        {
                            MessageBox.Show("Cliente não encontrado");
                            LimparCampos(); // Limpa os campos caso não encontre o cliente
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Favor preencher pelo menos um campo (CNPJ ou Nome) para realizar a pesquisa!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao encontrar o cliente: " + ex.Message);
            }
        }
    }
}

using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Util.BD;

namespace FazendaUrbanaDesktop.ModuloFornecedor
{
    public partial class frmGerenciarFornecedor : Form
    {
        private readonly ConexaoBanco _factory;

        public frmGerenciarFornecedor(ConexaoBanco factory)
        {
            InitializeComponent();
            _factory = factory;
            CarregarFornecedores(); // Carrega os fornecedores ao inicializar o formulário
        }

        private void frmGerenciarFornecedor_Load(object sender, EventArgs e)
        {
            dgGerenciarFornecedor.ReadOnly = true;
            dgGerenciarFornecedor.AllowUserToAddRows = false;
            dgGerenciarFornecedor.AllowUserToDeleteRows = false;
            dgGerenciarFornecedor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgGerenciarFornecedor.MultiSelect = false;
            dgGerenciarFornecedor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        // Função para carregar todos os fornecedores
        private void CarregarFornecedores()
        {
            try
            {
                var gerenciarFornecedores = new GerenciarFornecedor();
                DataTable tabelaFornecedores = gerenciarFornecedores.ObterTodosFornecedores(_factory);
                dgGerenciarFornecedor.DataSource = tabelaFornecedores;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar fornecedores: " + ex.Message);
            }
        }

        // Função para preencher os campos quando a linha for selecionada no DataGridView
        private void dgGerenciarFornecedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgGerenciarFornecedor.Rows[e.RowIndex];
                PreencherCampos(row);
            }
        }

        // Função para preencher os campos de texto com os dados da linha selecionada
        private void PreencherCampos(DataGridViewRow row)
        {
            txtNomeFornecedor.Text = row.Cells["nome"].Value.ToString();
            txtEmail.Text = row.Cells["email"].Value.ToString();
            mskCnpj.Text = row.Cells["cnpj"].Value.ToString();
            txtEndereco.Text = row.Cells["endereco"].Value.ToString();
        }

        // Botão de cadastrar fornecedor
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(txtNomeFornecedor.Text) &&
                    !string.IsNullOrWhiteSpace(txtEmail.Text) &&
                    !string.IsNullOrWhiteSpace(mskCnpj.Text) &&
                    !string.IsNullOrWhiteSpace(txtEndereco.Text))
                {
                    var cadFornecedor = new GerenciarFornecedor
                    {
                        NomeFornecedor = txtNomeFornecedor.Text,
                        Email = txtEmail.Text,
                        Cnpj = mskCnpj.Text,
                        Endereco = txtEndereco.Text
                    };

                    if (cadFornecedor.CadastrarFornecedor(_factory))
                    {
                        MessageBox.Show($"O fornecedor {cadFornecedor.NomeFornecedor} foi cadastrado com sucesso!");
                        LimparCampos();
                        CarregarFornecedores();
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível cadastrar o fornecedor!");
                    }
                }
                else
                {
                    MessageBox.Show("Favor preencher todos os campos corretamente!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar fornecedor: " + ex.Message);
            }
        }

        // Botão de atualizar fornecedor
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgGerenciarFornecedor.SelectedRows.Count > 0)
                {
                    var linha = dgGerenciarFornecedor.SelectedRows[0];
                    string cnpj = linha.Cells["cnpj"].Value.ToString(); // Pega o CNPJ da linha selecionada

                    string nome = string.IsNullOrWhiteSpace(txtNomeFornecedor.Text) ? linha.Cells["nome"].Value.ToString() : txtNomeFornecedor.Text;
                    string email = string.IsNullOrWhiteSpace(txtEmail.Text) ? linha.Cells["email"].Value.ToString() : txtEmail.Text;
                    string endereco = string.IsNullOrWhiteSpace(txtEndereco.Text) ? linha.Cells["endereco"].Value.ToString() : txtEndereco.Text;

                    var fornecedorAtualizar = new GerenciarFornecedor
                    {
                        Cnpj = cnpj,
                        NomeFornecedor = nome,
                        Email = email,
                        Endereco = endereco
                    };

                    if (fornecedorAtualizar.AtualizarFornecedor(_factory))
                    {
                        MessageBox.Show("Os dados do fornecedor foram atualizados com sucesso!");
                        LimparCampos();
                        CarregarFornecedores();
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível atualizar os dados do fornecedor.");
                    }
                }
                else
                {
                    MessageBox.Show("Selecione um fornecedor para atualizar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao atualizar dados do fornecedor: {ex.Message}");
            }
        }

        // Botão de deletar fornecedor
        private void btnDeletar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgGerenciarFornecedor.SelectedRows.Count > 0)
                {
                    var linha = dgGerenciarFornecedor.SelectedRows[0];
                    string cnpj = linha.Cells["cnpj"].Value.ToString();

                    var fornecedorDeletar = new GerenciarFornecedor
                    {
                        Cnpj = cnpj
                    };

                    if (fornecedorDeletar.DeletarFornecedor(_factory))
                    {
                        MessageBox.Show("O fornecedor foi excluído com sucesso!");
                        LimparCampos();
                        CarregarFornecedores();
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível excluir o fornecedor.");
                    }
                }
                else
                {
                    MessageBox.Show("Selecione um fornecedor para excluir.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao excluir fornecedor: {ex.Message}");
            }
        }

        // Função para limpar os campos de texto
        private void LimparCampos()
        {
            txtNomeFornecedor.Clear();
            txtEmail.Clear();
            mskCnpj.Clear();
            txtEndereco.Clear();
            mskCnpj.Focus(); // Foca no campo CNPJ após limpar
        }

        // Evento de pesquisa, que atualiza os fornecedores no DataGridView conforme a digitação
        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            string pesquisa = txtPesquisa.Text;
            using (SqlConnection conn = _factory.ObterConexao())
            {
                conn.Open();
                string query = "SELECT nome, cnpj, email, endereco FROM Fornecedor WHERE nome LIKE @pesquisa OR cnpj LIKE @pesquisa";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@pesquisa", $"%{pesquisa}%");
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgGerenciarFornecedor.DataSource = dt; // Atualiza o DataGridView com os resultados da pesquisa
                }
            }
        }
    }
}
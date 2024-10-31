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
            CarregarFornecedores();
        }

        private void frmGerenciarFornecedor_Load(object sender, EventArgs e)
        {
            // Configurações do DataGridView
            dgGerenciarFornecedor.ReadOnly = true;
            dgGerenciarFornecedor.AllowUserToAddRows = false;
            dgGerenciarFornecedor.AllowUserToDeleteRows = false;
            dgGerenciarFornecedor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgGerenciarFornecedor.MultiSelect = false;
            dgGerenciarFornecedor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void CarregarFornecedores()
        {
            try
            {
                var gerenciarFornecedor = new GerenciarFornecedor();
                DataTable tabelaFornecedores = gerenciarFornecedor.ObterTodosFornecedores(_factory);
                dgGerenciarFornecedor.DataSource = tabelaFornecedores;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar fornecedores: " + ex.Message);
            }
        }

        private void dgGerenciarFornecedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgGerenciarFornecedor.Rows[e.RowIndex];
                PreencherCampos(row);
            }
        }

        private void PreencherCampos(DataGridViewRow row)
        {
            txtNomeFornecedor.Text = row.Cells["nome"].Value.ToString();
            txtEmail.Text = row.Cells["email"].Value.ToString();
            mskCnpj.Text = row.Cells["cnpj"].Value.ToString();
            txtEndereco.Text = row.Cells["endereco"].Value.ToString();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(txtNomeFornecedor.Text) &&
                    !string.IsNullOrWhiteSpace(txtEmail.Text) &&
                    !string.IsNullOrWhiteSpace(mskCnpj.Text) &&
                    !string.IsNullOrWhiteSpace(txtEndereco.Text))
                {
                    var fornecedor = new GerenciarFornecedor
                    {
                        NomeFornecedor = txtNomeFornecedor.Text,
                        Email = txtEmail.Text,
                        Cnpj = mskCnpj.Text,
                        Endereco = txtEndereco.Text
                    };

                    if (fornecedor.CadastrarFornecedor(_factory))
                    {
                        MessageBox.Show($"O fornecedor {fornecedor.NomeFornecedor} foi cadastrado com sucesso!");
                        LimparCampos();
                        CarregarFornecedores();
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível cadastrar o fornecedor.");
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

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(txtNomeFornecedor.Text) &&
                    !string.IsNullOrWhiteSpace(txtEmail.Text) &&
                    !string.IsNullOrWhiteSpace(mskCnpj.Text) &&
                    !string.IsNullOrWhiteSpace(txtEndereco.Text))
                {
                    var fornecedor = new GerenciarFornecedor
                    {
                        Cnpj = mskCnpj.Text,
                        NomeFornecedor = txtNomeFornecedor.Text,
                        Email = txtEmail.Text,
                        Endereco = txtEndereco.Text
                    };

                    if (fornecedor.AtualizarFornecedor(_factory))
                    {
                        MessageBox.Show("Os dados do fornecedor foram atualizados com sucesso!");
                        LimparCampos();
                        CarregarFornecedores();
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível atualizar as informações do fornecedor.");
                    }
                }
                else
                {
                    MessageBox.Show("Favor localizar o fornecedor que deseja atualizar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar dados do fornecedor: " + ex.Message);
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgGerenciarFornecedor.SelectedRows.Count > 0)
                {
                    var linha = dgGerenciarFornecedor.SelectedRows[0];
                    string cnpj = linha.Cells["cnpj"].Value.ToString();

                    var fornecedor = new GerenciarFornecedor
                    {
                        Cnpj = cnpj
                    };

                    if (fornecedor.DeletarFornecedor(_factory))
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
                MessageBox.Show("Erro ao excluir fornecedor: " + ex.Message);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(mskCnpj.Text) || !string.IsNullOrWhiteSpace(txtNomeFornecedor.Text))
                {
                    var fornecedor = new GerenciarFornecedor
                    {
                        Cnpj = mskCnpj.Text,
                        NomeFornecedor = txtNomeFornecedor.Text
                    };

                    using (SqlDataReader reader = fornecedor.LocalizarFornecedor(_factory))
                    {
                        if (reader != null && reader.HasRows)
                        {
                            reader.Read();
                            txtNomeFornecedor.Text = reader["nome"].ToString();
                            txtEmail.Text = reader["email"].ToString();
                            mskCnpj.Text = reader["cnpj"].ToString();
                            txtEndereco.Text = reader["endereco"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Fornecedor não encontrado.");
                            LimparCampos();
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
                MessageBox.Show("Erro ao encontrar o fornecedor: " + ex.Message);
            }
        }

        private void LimparCampos()
        {
            txtNomeFornecedor.Clear();
            txtEmail.Clear();
            mskCnpj.Clear();
            txtEndereco.Clear();
            mskCnpj.Focus();
        }

        private void dgGerenciarFornecedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

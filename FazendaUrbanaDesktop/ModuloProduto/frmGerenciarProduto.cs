using System;
using System.Data;
using System.Windows.Forms;
using Util.BD; // Assegure-se de que esse namespace está correto
using System.Data.SqlClient;

namespace FazendaUrbanaDesktop.ModuloProduto
{
    public partial class frmGerenciarProduto : Form
    {
        private readonly ConexaoBanco _factory;

        public frmGerenciarProduto(ConexaoBanco factory)
        {
            InitializeComponent();
            _factory = factory;
            CarregarProdutos(); // Carregar produtos ao inicializar o formulário
        }

        private void CarregarProdutosFiltrados(string nomeProduto)
        {
            DataTable tabelaProdutos = new GerenciarProdutos().LocalizarProduto(nomeProduto, _factory);
            dgGerenciarProdutos.DataSource = tabelaProdutos;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(txtNomeProduto.Text) &&
                    !string.IsNullOrWhiteSpace(txtQuantidade.Text) &&
                    !string.IsNullOrWhiteSpace(mskDataPlantio.Text))
                {
                    var cadProdutos = new GerenciarProdutos
                    {
                        NomeProduto = txtNomeProduto.Text,
                        Quantidade = int.Parse(txtQuantidade.Text),
                        DataPlantio = DateTime.ParseExact(mskDataPlantio.Text, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture)
                    };

                    if (cadProdutos.CadastrarProduto(_factory))
                    {
                        MessageBox.Show($"O produto {cadProdutos.NomeProduto} foi cadastrado com sucesso!");
                        LimparCampos();
                        CarregarProdutos(); // Recarrega a lista de produtos
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível cadastrar o produto!");
                    }
                }
                else
                {
                    MessageBox.Show("Favor preencher todos os campos corretamente!");
                    LimparCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar produto: " + ex.Message);
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgGerenciarProdutos.SelectedRows.Count > 0)
                {
                    string nomeProdutoAtual = dgGerenciarProdutos.SelectedRows[0].Cells["nome"].Value.ToString();
                    int quantidadeAtual = int.Parse(dgGerenciarProdutos.SelectedRows[0].Cells["quantidade"].Value.ToString());

                    var cadProdutos = new GerenciarProdutos
                    {
                        NomeProduto = txtNomeProduto.Text,
                        Quantidade = int.Parse(txtQuantidade.Text)
                    };

                    if (cadProdutos.AtualizarProduto(nomeProdutoAtual, quantidadeAtual, _factory))
                    {
                        MessageBox.Show("Os dados do produto foram atualizados com sucesso!");
                        CarregarProdutos();
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível atualizar as informações do produto.");
                    }
                }
                else
                {
                    MessageBox.Show("Favor selecionar um produto para atualizar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar dados do produto: " + ex.Message);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(txtNomeProduto.Text))
                {
                    CarregarProdutosFiltrados(txtNomeProduto.Text);
                }
                else
                {
                    MessageBox.Show("Favor preencher o campo NomeProduto, para realizar a pesquisa!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao encontrar o produto: " + ex.Message);
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgGerenciarProdutos.SelectedRows.Count > 0)
                {
                    string nomeProduto = dgGerenciarProdutos.SelectedRows[0].Cells["nome"].Value.ToString();
                    int quantidade = int.Parse(dgGerenciarProdutos.SelectedRows[0].Cells["quantidade"].Value.ToString());
                    DateTime dataPlantio = DateTime.Parse(dgGerenciarProdutos.SelectedRows[0].Cells["data_plantio"].Value.ToString());

                    var cadProdutos = new GerenciarProdutos
                    {
                        NomeProduto = nomeProduto,
                        Quantidade = quantidade,
                        DataPlantio = dataPlantio
                    };

                    if (cadProdutos.DeletarProduto(_factory))
                    {
                        MessageBox.Show($"O produto {nomeProduto} foi excluído com sucesso!");
                        CarregarProdutos();
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível excluir o produto.");
                    }
                }
                else
                {
                    MessageBox.Show("Favor selecionar um produto para excluir.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir produto: " + ex.Message);
            }
        }

        private void CarregarProdutos()
        {
            try
            {
                // Não use 'using' aqui para a conexão com o banco
                var conexaoBanco = _factory; // Usa a instância de ConexaoBanco passada no construtor
                using (SqlConnection sqlConexaoBanco = conexaoBanco.ObterConexao())
                {
                    sqlConexaoBanco.Open();

                    string select = "SELECT nome, quantidade, data_plantio FROM produto";
                    using (SqlCommand comandoSql = new SqlCommand(select, sqlConexaoBanco))
                    {
                        using (SqlDataReader reader = comandoSql.ExecuteReader())
                        {
                            DataTable dataTable = new DataTable();
                            dataTable.Load(reader);
                            dgGerenciarProdutos.DataSource = dataTable; // Preenche o DataGridView com os produtos
                        }
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("Erro de SQL: " + sqlEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar produtos: " + ex.Message);
            }
        }

        private void LimparCampos()
        {
            txtNomeProduto.Clear();
            txtQuantidade.Clear();
            mskDataPlantio.Clear();
            txtNomeProduto.Focus();
        }
    }
}

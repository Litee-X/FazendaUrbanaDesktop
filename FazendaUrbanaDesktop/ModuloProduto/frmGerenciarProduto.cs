using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Util.BD;

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

        private void CarregarProdutosFiltrados(string pesquisa)
        {
            DataTable tabelaProdutos = new GerenciarProdutos().LocalizarProduto(pesquisa, _factory);
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
                    // Converte o texto da máscara de data para DateTime
                    DateTime dataPlantio = DateTime.ParseExact(mskDataPlantio.Text, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);

                    // Cria o objeto de produto
                    var cadProdutos = new GerenciarProdutos
                    {
                        NomeProduto = txtNomeProduto.Text,
                        Quantidade = int.Parse(txtQuantidade.Text),
                        DataPlantio = dataPlantio
                    };

                    // Tenta cadastrar o produto
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
                    // Obter dados da linha selecionada no DataGridView
                    var linha = dgGerenciarProdutos.SelectedRows[0];
                    string nomeProdutoAtual = linha.Cells["nome"].Value.ToString();
                    int quantidadeAtual = int.Parse(linha.Cells["quantidade"].Value.ToString());
                    DateTime dataPlantioAtual = DateTime.Parse(linha.Cells["data_plantio"].Value.ToString());

                    // Recuperar valores dos campos para atualização
                    string nomeProduto = string.IsNullOrWhiteSpace(txtNomeProduto.Text) ? nomeProdutoAtual : txtNomeProduto.Text;
                    int quantidade = string.IsNullOrWhiteSpace(txtQuantidade.Text) ? quantidadeAtual : int.Parse(txtQuantidade.Text);
                    DateTime dataPlantio = dataPlantioAtual;

                    var produtoAtualizar = new GerenciarProdutos
                    {
                        NomeProduto = nomeProduto,
                        Quantidade = quantidade,
                        DataPlantio = dataPlantio
                    };

                    if (produtoAtualizar.AtualizarProduto(nomeProdutoAtual, quantidadeAtual, _factory))
                    {
                        MessageBox.Show("Os dados do produto foram atualizados com sucesso!");
                        LimparCampos();
                        CarregarProdutos();
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível atualizar as informações do produto.");
                    }
                }
                else
                {
                    MessageBox.Show("Selecione um produto para atualizar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao atualizar dados do produto: {ex.Message}");
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
                        CarregarProdutos(); // Atualiza a lista após exclusão
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível excluir o produto!");
                    }
                }
                else
                {
                    MessageBox.Show("Selecione um produto para excluir.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao excluir produto: {ex.Message}");
            }
        }

        private void CarregarProdutos()
        {
            var gerenciarProdutos = new GerenciarProdutos();
            DataTable tabelaProdutos = gerenciarProdutos.LocalizarProduto("", _factory);
            dgGerenciarProdutos.DataSource = tabelaProdutos;
        }

        private void LimparCampos()
        {
            txtNomeProduto.Clear();
            txtQuantidade.Clear();
            mskDataPlantio.Clear();
            txtNomeProduto.Focus();
        }

        // Novo evento para pesquisa em tempo real no campo txtPesquisa
        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            string pesquisa = txtPesquisa.Text;
            if (!string.IsNullOrEmpty(pesquisa))
            {
                CarregarProdutosFiltrados(pesquisa); // Chama o método de busca
            }
            else
            {
                CarregarProdutos(); // Recarrega todos os produtos se o campo de pesquisa estiver vazio
            }
        }
    }
}

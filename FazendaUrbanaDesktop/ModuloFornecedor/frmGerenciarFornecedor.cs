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
            // Configurações do DataGridView
            dgGerenciarFornecedor.ReadOnly = true; // Define o DataGridView como somente leitura
            dgGerenciarFornecedor.AllowUserToAddRows = false; // Impede a adição de novas linhas
            dgGerenciarFornecedor.AllowUserToDeleteRows = false; // Impede a exclusão de linhas
            dgGerenciarFornecedor.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Seleciona a linha inteira
            dgGerenciarFornecedor.MultiSelect = false; // Desabilita a seleção de múltiplas linhas
            dgGerenciarFornecedor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Preenche todo o espaço disponível
        }

        // Função para carregar todos os fornecedores
        private void CarregarFornecedores()
        {
            try
            {
                var gerenciarFornecedores = new GerenciarFornecedor();
                DataTable tabelaFornecedores = gerenciarFornecedores.ObterTodosFornecedores(_factory);
                dgGerenciarFornecedor.DataSource = tabelaFornecedores; // Preenche o DataGridView com os fornecedores
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar fornecedores: " + ex.Message);
            }
        }

        // Função para carregar a seleção da linha no DataGridView para os campos
        private void dgGerenciarFornecedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Verifica se a linha clicada é válida
            {
                var row = dgGerenciarFornecedor.Rows[e.RowIndex];
                PreencherCampos(row); // Preenche os campos com os dados da linha selecionada
            }
        }

        // Função para preencher os campos de texto com os dados da linha selecionada
        private void PreencherCampos(DataGridViewRow row)
        {
            txtNomeFornecedor.Text = row.Cells["nome"].Value.ToString();
            txtEmail.Text = row.Cells["email"].Value.ToString();
            mskCnpj.Text = row.Cells["cnpj"].Value.ToString();
            txtEndereco.Text = row.Cells["endereco"].Value.ToString(); // Preenchendo o endereço
        }

        // Botão de cadastrar fornecedor
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(txtNomeFornecedor.Text) &&
                    !string.IsNullOrWhiteSpace(txtEmail.Text) &&
                    !string.IsNullOrWhiteSpace(mskCnpj.Text) &&
                    !string.IsNullOrWhiteSpace(txtEndereco.Text)) // Verificando endereço
                {
                    var cadFornecedor = new GerenciarFornecedor
                    {
                        NomeFornecedor = txtNomeFornecedor.Text,
                        Email = txtEmail.Text,
                        Cnpj = mskCnpj.Text,
                        Endereco = txtEndereco.Text // Adicionando endereço
                    };

                    // Chama o método para cadastrar
                    if (cadFornecedor.CadastrarFornecedor(_factory))
                    {
                        MessageBox.Show($"O fornecedor {cadFornecedor.NomeFornecedor} foi cadastrado com sucesso!");
                        LimparCampos(); // Limpa os campos após cadastrar
                        CarregarFornecedores(); // Recarrega a lista de fornecedores
                    }
                }
                else
                {
                    MessageBox.Show("Favor preencher todos os campos obrigatórios!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar fornecedor: " + ex.Message);
            }
        }

        // Botão de pesquisar fornecedor
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(mskCnpj.Text)) // Verifica se o CNPJ foi preenchido
                {
                    var gerenciarFornecedores = new GerenciarFornecedor();
                    DataTable tabelaFornecedores = gerenciarFornecedores.LocalizarFornecedorPorCnpj(mskCnpj.Text, _factory);

                    if (tabelaFornecedores.Rows.Count > 0)
                    {
                        dgGerenciarFornecedor.DataSource = tabelaFornecedores; // Atualiza o DataGridView com os resultados encontrados
                    }
                    else
                    {
                        MessageBox.Show("Fornecedor não encontrado");
                        CarregarFornecedores(); // Recarrega todos os fornecedores caso não encontre
                    }
                }
                else
                {
                    MessageBox.Show("Favor preencher o CNPJ para realizar a pesquisa!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao encontrar o fornecedor: " + ex.Message);
            }
        }

        // Botão de atualizar fornecedor
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(mskCnpj.Text)) // Verifica se o CNPJ foi preenchido
                {
                    var atualizarFornecedor = new GerenciarFornecedor
                    {
                        NomeFornecedor = txtNomeFornecedor.Text,
                        Email = txtEmail.Text,
                        Cnpj = mskCnpj.Text,
                        Endereco = txtEndereco.Text // Adicionando endereço
                    };

                    // Chama o método para atualizar
                    if (atualizarFornecedor.AtualizarFornecedor(_factory))
                    {
                        MessageBox.Show($"O fornecedor {atualizarFornecedor.NomeFornecedor} foi atualizado com sucesso!");
                        LimparCampos(); // Limpa os campos após atualizar
                        CarregarFornecedores(); // Recarrega a lista de fornecedores
                    }
                }
                else
                {
                    MessageBox.Show("Favor preencher o CNPJ do fornecedor para realizar a atualização!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar fornecedor: " + ex.Message);
            }
        }

        // Botão de deletar fornecedor
        private void btnDeletar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(mskCnpj.Text)) // Verifica se o CNPJ foi preenchido
                {
                    var deletarFornecedor = new GerenciarFornecedor
                    {
                        Cnpj = mskCnpj.Text // Passa o CNPJ para deletar
                    };

                    // Chama o método para deletar
                    if (deletarFornecedor.DeletarFornecedor(_factory))
                    {
                        MessageBox.Show($"O fornecedor com CNPJ {deletarFornecedor.Cnpj} foi excluído com sucesso!");
                        LimparCampos(); // Limpa os campos após excluir
                        CarregarFornecedores(); // Recarrega a lista de fornecedores
                    }
                }
                else
                {
                    MessageBox.Show("Favor preencher o CNPJ do fornecedor para realizar a exclusão!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir fornecedor: " + ex.Message);
            }
        }

        // Limpa os campos de texto
        private void LimparCampos()
        {
            txtNomeFornecedor.Clear();
            txtEmail.Clear();
            mskCnpj.Clear();
            txtEndereco.Clear(); // Limpa o campo de endereço
        }
    }
}
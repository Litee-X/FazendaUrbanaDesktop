using FazendaUrbanaDesktop.ModuloFuncionarios;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Util.BD;

namespace FazendaUrbanaDesktop
{
    public partial class frmFuncionarios : Form
    {
        private readonly ConexaoBanco _factory;

        public frmFuncionarios(ConexaoBanco factory)
        {
            InitializeComponent();
            _factory = factory;
            CarregarFuncionarios(); // Carrega os funcionários ao inicializar o formulário
        }

        private void frmFuncionarios_Load(object sender, EventArgs e)
        {
            dgCadastrarFuncionario.ReadOnly = true; // Define o DataGridView como somente leitura
            dgCadastrarFuncionario.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Seleciona a linha inteira
            dgCadastrarFuncionario.MultiSelect = false; // Desabilita a seleção de múltiplas linhas
        }

        // Função para carregar todos os funcionários
        private void CarregarFuncionarios()
        {
            try
            {
                var cadFuncionarios = new CadastroFuncionarios();
                DataTable tabelaFuncionarios = cadFuncionarios.ObterTodosFuncionarios(_factory);
                dgCadastrarFuncionario.DataSource = tabelaFuncionarios; // Preenche o DataGridView com os funcionários
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar funcionários: " + ex.Message);
            }
        }

        // Função para carregar a seleção da linha no DataGridView para os campos
        private void dgCadastrarFuncionario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Verifica se a linha clicada é válida
            {
                var row = dgCadastrarFuncionario.Rows[e.RowIndex];
                PreencherCampos(row); // Preenche os campos com os dados da linha selecionada
            }
        }

        // Função para preencher os campos de texto com os dados da linha selecionada
        private void PreencherCampos(DataGridViewRow row)
        {
            lblId.Text = row.Cells["id"].Value.ToString();
            txtNome.Text = row.Cells["nome"].Value.ToString();
            txtEmail.Text = row.Cells["email"].Value.ToString();
            mskCpf.Text = row.Cells["cpf"].Value.ToString();
            txtEndereco.Text = row.Cells["endereco"].Value.ToString();
        }

        // Botão de cadastrar funcionário
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(txtNome.Text) &&
                    !string.IsNullOrWhiteSpace(txtEmail.Text) &&
                    !string.IsNullOrWhiteSpace(mskCpf.Text) &&
                    !string.IsNullOrWhiteSpace(txtEndereco.Text))
                {
                    var cadFuncionarios = new CadastroFuncionarios
                    {
                        Nome = txtNome.Text,
                        Email = txtEmail.Text,
                        Cpf = mskCpf.Text,
                        Endereco = txtEndereco.Text
                    };

                    if (!cadFuncionarios.CpfJaCadastrado(_factory)) // Verifica se o CPF já está cadastrado
                    {
                        if (cadFuncionarios.CadastrarFuncionarios(_factory))
                        {
                            MessageBox.Show($"O funcionário {cadFuncionarios.Nome} foi cadastrado com sucesso!");
                            LimparCampos();
                            CarregarFuncionarios(); // Recarrega a lista de funcionários
                        }
                        else
                        {
                            MessageBox.Show("Não foi possível cadastrar o funcionário!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("CPF já cadastrado! Por favor, utilize um CPF diferente.");
                    }
                }
                else
                {
                    MessageBox.Show("Favor preencher todos os campos corretamente!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar funcionário: " + ex.Message);
            }
        }

        // Botão de atualizar funcionário
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(mskCpf.Text) &&
                    !string.IsNullOrWhiteSpace(txtNome.Text) &&
                    !string.IsNullOrWhiteSpace(txtEmail.Text) &&
                    !string.IsNullOrWhiteSpace(txtEndereco.Text))
                {
                    var cadFuncionarios = new CadastroFuncionarios
                    {
                        Cpf = mskCpf.Text,
                        Nome = txtNome.Text,
                        Email = txtEmail.Text,
                        Endereco = txtEndereco.Text
                    };

                    if (cadFuncionarios.AtualizarFuncionarioPorCpf(_factory))
                    {
                        MessageBox.Show("Os dados do funcionário foram atualizados com sucesso!");
                        LimparCampos();
                        CarregarFuncionarios(); // Recarrega a lista de funcionários
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível atualizar as informações do funcionário");
                    }
                }
                else
                {
                    MessageBox.Show("Favor localizar o funcionário que deseja atualizar as informações");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar dados do funcionário: " + ex.Message);
            }
        }

        // Botão de deletar funcionário
        private void btnDeletar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgCadastrarFuncionario.SelectedRows.Count > 0) // Verifica se há uma linha selecionada
                {
                    // Obtém o CPF do funcionário selecionado
                    var linha = dgCadastrarFuncionario.SelectedRows[0];
                    string cpf = linha.Cells["cpf"].Value.ToString(); // Captura o CPF do funcionário

                    var cadFuncionarios = new CadastroFuncionarios
                    {
                        Cpf = cpf // Usar CPF para deletar
                    };

                    // Chama o método de exclusão
                    if (cadFuncionarios.DeletarFuncionarioPorCpf(_factory))
                    {
                        MessageBox.Show("O funcionário foi excluído com sucesso!");
                        LimparCampos();
                        CarregarFuncionarios(); // Recarrega a lista de funcionários
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível excluir o funcionário");
                    }
                }
                else
                {
                    MessageBox.Show("Selecione um funcionário para excluir.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir funcionário: " + ex.Message);
            }
        }

        // Função para limpar os campos de texto
        private void LimparCampos()
        {
            lblId.Text = string.Empty;
            txtNome.Clear();
            txtEmail.Clear();
            mskCpf.Clear();
            txtEndereco.Clear();
            mskCpf.Focus();
        }
    }
}

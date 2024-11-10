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
            txtNome.Focus(); // Foca no primeiro campo de texto
            CarregarFuncionarios(); // Carrega a lista de funcionários
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
            if (dgCadastrarFuncionario.SelectedRows.Count > 0)
            {
                var linha = dgCadastrarFuncionario.SelectedRows[0];
                txtNome.Text = linha.Cells["nome"].Value.ToString();
                mskCpf.Text = linha.Cells["cpf"].Value.ToString();
                txtEmail.Text = linha.Cells["email"].Value.ToString();
                txtEndereco.Text = linha.Cells["endereco"].Value.ToString();
            }
        }

        // Botão de cadastrar funcionário
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            CadastrarFuncionario();
        }

        private void CadastrarFuncionario()
        {
            try
            {
                string nome = txtNome.Text;
                string cpf = mskCpf.Text;
                string email = txtEmail.Text;
                string endereco = txtEndereco.Text;

                if (!string.IsNullOrWhiteSpace(nome) && !string.IsNullOrWhiteSpace(cpf) && !string.IsNullOrWhiteSpace(email) && !string.IsNullOrWhiteSpace(endereco))
                {
                    var cadFuncionarios = new CadastroFuncionarios
                    {
                        Nome = nome,
                        Cpf = cpf,
                        Email = email,
                        Endereco = endereco
                    };

                    if (!cadFuncionarios.CpfJaCadastrado(_factory))
                    {
                        if (cadFuncionarios.CadastrarFuncionario(_factory))
                        {
                            MessageBox.Show("Funcionário cadastrado com sucesso!");
                            LimparCampos();
                            CarregarFuncionarios();
                        }
                        else
                        {
                            MessageBox.Show("Erro ao cadastrar funcionário.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("CPF já cadastrado.");
                    }
                }
                else
                {
                    MessageBox.Show("Preencha todos os campos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        // Botão de atualizar funcionário
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgCadastrarFuncionario.SelectedRows.Count > 0)
                {
                    var linha = dgCadastrarFuncionario.SelectedRows[0];
                    string cpf = linha.Cells["cpf"].Value.ToString(); // Obtém o CPF do funcionário

                    // Obtem os valores dos campos; se vazio, mantém o valor original do DataGridView
                    string nome = string.IsNullOrWhiteSpace(txtNome.Text) ? linha.Cells["nome"].Value.ToString() : txtNome.Text;
                    string email = string.IsNullOrWhiteSpace(txtEmail.Text) ? linha.Cells["email"].Value.ToString() : txtEmail.Text;
                    string endereco = string.IsNullOrWhiteSpace(txtEndereco.Text) ? linha.Cells["endereco"].Value.ToString() : txtEndereco.Text;

                    var cadFuncionarios = new CadastroFuncionarios
                    {
                        Nome = nome,
                        Cpf = cpf,
                        Email = email,
                        Endereco = endereco
                    };

                    if (cadFuncionarios.AtualizarFuncionarioPorCpf(_factory))
                    {
                        MessageBox.Show("Funcionário atualizado com sucesso!");
                        LimparCampos();
                        CarregarFuncionarios(); // Recarrega os dados atualizados no DataGridView
                    }
                    else
                    {
                        MessageBox.Show("Erro ao atualizar funcionário.");
                    }
                }
                else
                {
                    MessageBox.Show("Selecione um funcionário para atualizar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        // Função para deletar um funcionário
        private void btnDeletar_Click(object sender, EventArgs e)
        {
            DeletarFuncionario();
        }

        private void DeletarFuncionario()
        {
            try
            {
                if (dgCadastrarFuncionario.SelectedRows.Count > 0)
                {
                    var linha = dgCadastrarFuncionario.SelectedRows[0];
                    string cpf = linha.Cells["cpf"].Value.ToString();

                    var cadFuncionarios = new CadastroFuncionarios { Cpf = cpf };

                    if (cadFuncionarios.DeletarFuncionarioPorCpf(_factory))
                    {
                        MessageBox.Show("Funcionário deletado com sucesso!");
                        LimparCampos();
                        CarregarFuncionarios(); // Recarrega os dados no DataGridView
                    }
                    else
                    {
                        MessageBox.Show("Erro ao deletar funcionário.");
                    }
                }
                else
                {
                    MessageBox.Show("Selecione um funcionário para deletar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        // Função para limpar os campos de texto
        private void LimparCampos()
        {
            txtNome.Clear();
            mskCpf.Clear();
            txtEmail.Clear();
            txtEndereco.Clear();
            txtNome.Focus(); // Foca no campo nome
        }

        private void txtPesquisa_TextChanged_1(object sender, EventArgs e)
        {
            string pesquisa = txtPesquisa.Text;
            using (SqlConnection conn = _factory.ObterConexao())
            {
                conn.Open();
                string query = "SELECT nome, cpf, email, endereco FROM Funcionarios WHERE nome LIKE @pesquisa OR cpf LIKE @pesquisa";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@pesquisa", $"%{pesquisa}%");
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgCadastrarFuncionario.DataSource = dt;
                }
            }
        }
    }
}

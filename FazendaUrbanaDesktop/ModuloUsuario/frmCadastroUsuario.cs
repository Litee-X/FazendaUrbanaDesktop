using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Util.BD;
using Util.Encrypt;

namespace FazendaUrbanaDesktop.ModuloUsuario
{
    public partial class frmCadastroUsuario : Form
    {
        private readonly ConexaoBanco _factory;
        private readonly PasswordHasher _passwordHasher;

        public frmCadastroUsuario(ConexaoBanco factory)
        {
            InitializeComponent();
            _factory = factory;
            _passwordHasher = new PasswordHasher();
            CarregarUsuarios(); // Carrega os usuários ao inicializar o formulário
        }

        private void btnCadastrar_Click_1(object sender, EventArgs e)
        {
            CadastrarUsuario();
        }

        private void CadastrarUsuario()
        {
            try
            {
                string nome = txtNome.Text;
                string cpf = mskCpf.Text;
                string email = txtEmail.Text;
                string endereco = txtEndereco.Text;

                // Remove a máscara do CPF
                string cpfSemMascara = cpf.Replace(".", "").Replace("-", "");
                // Gera hash para o CPF como senha
                string senhaHash = _passwordHasher.HashPassword(cpfSemMascara);

                var gerenciarUsuario = new GerenciarUsuario();
                if (gerenciarUsuario.CadastrarUsuario(_factory, nome, senhaHash, cpfSemMascara, email, endereco))
                {
                    MessageBox.Show("Usuário cadastrado com sucesso!");
                    CarregarUsuarios(); // Recarrega a lista de usuários
                    LimparCampos(); // Limpa os campos após cadastro
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar usuário. O nome pode já estar em uso.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void LimparCampos()
        {
            txtNome.Clear();
            mskCpf.Clear();
            txtEmail.Clear();
            txtEndereco.Clear();
            txtNome.Focus();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgCadastrarUsuario.SelectedRows.Count > 0)
                {
                    var linha = dgCadastrarUsuario.SelectedRows[0];
                    string cpfOriginal = linha.Cells["cpf"].Value.ToString(); // Usando CPF como chave primária

                    // Obtem os valores dos campos; se vazio, mantém o valor original do DataGridView
                    string nome = string.IsNullOrWhiteSpace(txtNome.Text) ? linha.Cells["login"].Value.ToString() : txtNome.Text;
                    string cpf = string.IsNullOrWhiteSpace(mskCpf.Text) ? cpfOriginal : mskCpf.Text;
                    string email = string.IsNullOrWhiteSpace(txtEmail.Text) ? linha.Cells["email"].Value.ToString() : txtEmail.Text;
                    string endereco = string.IsNullOrWhiteSpace(txtEndereco.Text) ? linha.Cells["endereco"].Value.ToString() : txtEndereco.Text;

                    // Remove a máscara do CPF
                    string cpfSemMascara = cpf.Replace(".", "").Replace("-", "");

                    // Gera hash para o CPF como senha
                    string senhaHash = _passwordHasher.HashPassword(cpfSemMascara);

                    var gerenciarUsuario = new GerenciarUsuario();
                    if (gerenciarUsuario.AtualizarUsuario(_factory, nome, senhaHash, email, endereco, cpfOriginal))
                    {
                        MessageBox.Show("Usuário atualizado com sucesso!");
                        LimparCampos();
                        CarregarUsuarios(); // Recarrega a lista de usuários após a atualização
                    }
                    else
                    {
                        MessageBox.Show("Erro ao atualizar usuário.");
                    }
                }
                else
                {
                    MessageBox.Show("Selecione um usuário para atualizar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgCadastrarUsuario.SelectedRows.Count > 0)
                {
                    var linha = dgCadastrarUsuario.SelectedRows[0];
                    string nome = linha.Cells["login"].Value.ToString();

                    var gerenciarUsuario = new GerenciarUsuario();
                    if (gerenciarUsuario.DeletarUsuario(_factory, nome))
                    {
                        MessageBox.Show("Usuário deletado com sucesso!");
                        CarregarUsuarios();
                    }
                    else
                    {
                        MessageBox.Show("Erro ao deletar usuário.");
                    }
                }
                else
                {
                    MessageBox.Show("Selecione um usuário para deletar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void CarregarUsuarios()
        {
            using (SqlConnection conn = _factory.ObterConexao())
            {
                conn.Open();
                string query = "SELECT login, cpf, email, endereco FROM Usuario";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgCadastrarUsuario.DataSource = dt;
            }
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            string pesquisa = txtPesquisa.Text;
            using (SqlConnection conn = _factory.ObterConexao())
            {
                conn.Open();
                string query = "SELECT login, cpf, email, endereco FROM Usuario WHERE login LIKE @pesquisa OR cpf LIKE @pesquisa";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@pesquisa", $"%{pesquisa}%");
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgCadastrarUsuario.DataSource = dt;
                }
            }
        }

        private void dgCadastrarUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgCadastrarUsuario.SelectedRows.Count > 0)
            {
                var linha = dgCadastrarUsuario.SelectedRows[0];
                txtNome.Text = linha.Cells["login"].Value.ToString();
                mskCpf.Text = linha.Cells["cpf"].Value.ToString();
                txtEmail.Text = linha.Cells["email"].Value.ToString();
                txtEndereco.Text = linha.Cells["endereco"].Value.ToString();
            }
        }
    }
}

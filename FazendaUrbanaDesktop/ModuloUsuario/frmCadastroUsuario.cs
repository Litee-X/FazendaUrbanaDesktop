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
            // Chama a função de cadastro ao clicar no botão "Cadastrar"
            CadastrarUsuario();
        }

        private void CadastrarUsuario()
        {
            try
            {
                string nome = txtNome.Text; // Usa o nome como login
                string cpf = mskCpf.Text;    // Usa o CPF como senha
                string email = txtEmail.Text; // Adiciona email
                string endereco = txtEndereco.Text; // Adiciona endereço

                // Remove a máscara do CPF para armazenar apenas os números
                string cpfSemMascara = cpf.Replace(".", "").Replace("-", "");

                // Cria o hash da senha (CPF)
                string senhaHash = _passwordHasher.HashPassword(cpfSemMascara);

                var gerenciarUsuario = new GerenciarUsuario();
                // Tenta cadastrar o usuário passando o nome (login), senha hash, CPF, email e endereço
                if (gerenciarUsuario.CadastrarUsuario(_factory, nome, senhaHash, cpfSemMascara, email, endereco))
                {
                    MessageBox.Show("Usuário cadastrado com sucesso!");
                    LimparCampos();
                    CarregarUsuarios(); // Atualiza a lista de usuários
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

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgCadastrarUsuario.SelectedRows.Count > 0)
                {
                    // Obtém o usuário selecionado
                    var linha = dgCadastrarUsuario.SelectedRows[0];
                    string nome = linha.Cells["login"].Value.ToString();
                    string cpf = mskCpf.Text;
                    string email = txtEmail.Text;
                    string endereco = txtEndereco.Text;

                    // Remove a máscara do CPF
                    string cpfSemMascara = cpf.Replace(".", "").Replace("-", "");

                    // Cria o hash da nova senha (CPF)
                    string senhaHash = _passwordHasher.HashPassword(cpfSemMascara);

                    var gerenciarUsuario = new GerenciarUsuario();
                    // Tenta atualizar o usuário
                    if (gerenciarUsuario.AtualizarUsuario(_factory, nome, senhaHash, email, endereco))
                    {
                        MessageBox.Show("Usuário atualizado com sucesso!");
                        LimparCampos();
                        CarregarUsuarios(); // Atualiza a lista de usuários
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
                    // Obtém o usuário selecionado
                    var linha = dgCadastrarUsuario.SelectedRows[0];
                    string nome = linha.Cells["login"].Value.ToString();

                    var gerenciarUsuario = new GerenciarUsuario();
                    // Tenta deletar o usuário
                    if (gerenciarUsuario.DeletarUsuario(_factory, nome))
                    {
                        MessageBox.Show("Usuário deletado com sucesso!");
                        CarregarUsuarios(); // Atualiza a lista de usuários
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
                dgCadastrarUsuario.DataSource = dt; // Atualiza o DataGridView com a lista de usuários
            }
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            string pesquisa = txtPesquisa.Text;
            using (SqlConnection conn = _factory.ObterConexao())
            {
                conn.Open();
                // Modifica a consulta para buscar por login ou CPF
                string query = "SELECT login, cpf, email, endereco FROM Usuario WHERE login LIKE @pesquisa OR cpf LIKE @pesquisa";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@pesquisa", $"%{pesquisa}%");
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgCadastrarUsuario.DataSource = dt; // Atualiza o DataGridView com os resultados da pesquisa
                }
            }
        }

        private void dgCadastrarUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgCadastrarUsuario.SelectedRows.Count > 0)
            {
                var linha = dgCadastrarUsuario.SelectedRows[0];
                // Carrega os dados do usuário selecionado nos campos de texto
                txtNome.Text = linha.Cells["login"].Value.ToString();
                mskCpf.Text = linha.Cells["cpf"].Value.ToString();
                txtEmail.Text = linha.Cells["email"].Value.ToString();
                txtEndereco.Text = linha.Cells["endereco"].Value.ToString();
            }
        }
    }
}

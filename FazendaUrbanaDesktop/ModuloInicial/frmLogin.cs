using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using Util.BD;
using Util.Encrypt;

namespace FazendaUrbanaDesktop.ModuloInicial
{
    public partial class frmLogin : Form
    {
        private readonly ConexaoBanco _factory;
        private readonly PasswordHasher _passwordHasher;

        // Credenciais do desenvolvedor
        private const string devLogin = "dev";
        private const string devSenha = "12345"; // Senha do desenvolvedor

        public frmLogin(ConexaoBanco factory)
        {
            InitializeComponent();
            _factory = factory;
            _passwordHasher = new PasswordHasher();
            txtSenha.MaxLength = 11; // CPF sem máscara
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string login = txtUsuario.Text; // Nome do usuário
                string senhaComMascara = txtSenha.Text; // CPF como senha

                // Remove a máscara do CPF
                string senhaSemMascara = senhaComMascara.Replace(".", "").Replace("-", "").Replace("/", "");

                // Verifica se é um login de desenvolvedor
                if (login.Equals(devLogin, StringComparison.OrdinalIgnoreCase) && senhaSemMascara == devSenha)
                {
                    AcessarMenu();
                }
                else if (ValidarLogin(login, senhaSemMascara)) // Passa a senha sem máscara
                {
                    AcessarMenu();
                }
                else
                {
                    MessageBox.Show("Login ou senha inválidos!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        public bool ValidarLogin(string login, string senha)
        {
            using (SqlConnection conn = _factory.ObterConexao())
            {
                conn.Open();
                string query = "SELECT senha FROM Usuario WHERE login = @login";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@login", login);
                    string senhaHash = (string)cmd.ExecuteScalar();

                    if (senhaHash != null)
                    {
                        return _passwordHasher.VerifyPassword(senha, senhaHash);
                    }
                    return false;
                }
            }
        }

        private void AcessarMenu()
        {
            this.Hide(); // Esconde o formulário de login
            frmMenu frmMenu = new frmMenu(_factory); // Cria uma nova instância do formulário de menu
            frmMenu.Closed += (s, args) => this.Close(); // Fecha o formulário de login ao fechar o menu
            frmMenu.Show(); // Mostra o formulário de menu
        }
    }
}

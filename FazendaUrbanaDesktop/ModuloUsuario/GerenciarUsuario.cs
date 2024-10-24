using System;
using System.Data.SqlClient;
using Util.BD;
using Util.Encrypt;

namespace FazendaUrbanaDesktop.ModuloUsuario
{
    public class GerenciarUsuario
    {
        public bool CadastrarUsuario(ConexaoBanco factory, string nome, string senhaHash, string cpf, string email, string endereco)
        {
            using (SqlConnection conn = factory.ObterConexao())
            {
                conn.Open();
                string query = "INSERT INTO Usuario (login, senha, cpf, email, endereco) VALUES (@nome, @senha, @cpf, @email, @endereco)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nome", nome);
                    cmd.Parameters.AddWithValue("@senha", senhaHash);
                    cmd.Parameters.AddWithValue("@cpf", cpf);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@endereco", endereco);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }

        public bool AtualizarUsuario(ConexaoBanco factory, string login, string senhaHash, string email, string endereco)
        {
            using (SqlConnection conn = factory.ObterConexao())
            {
                conn.Open();
                string query = "UPDATE Usuario SET senha = @senha, email = @email, endereco = @endereco WHERE login = @login";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@login", login);
                    cmd.Parameters.AddWithValue("@senha", senhaHash);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@endereco", endereco);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }

        public bool DeletarUsuario(ConexaoBanco factory, string login)
        {
            using (SqlConnection conn = factory.ObterConexao())
            {
                conn.Open();
                string query = "DELETE FROM Usuario WHERE login = @login";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@login", login);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }

        public bool ValidarLogin(ConexaoBanco factory, string login, string senha)
        {
            using (SqlConnection conn = factory.ObterConexao())
            {
                conn.Open();
                string query = "SELECT senha FROM Usuario WHERE login = @login";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@login", login);
                    string senhaHash = (string)cmd.ExecuteScalar();

                    if (senhaHash != null)
                    {
                        PasswordHasher passwordHasher = new PasswordHasher();
                        return passwordHasher.VerifyPassword(senha, senhaHash);
                    }
                    return false;
                }
            }
        }
    }
}

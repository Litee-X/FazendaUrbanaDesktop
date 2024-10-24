using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Util.BD;

namespace FazendaUrbanaDesktop.ModuloCliente
{
    internal class GerenciarCliente
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Cnpj { get; set; }
        public int Id { get; set; }
        public string Endereco { get; set; } // Adicionando a propriedade Endereco

        public bool CadastrarCliente(ConexaoBanco factory)
        {
            try
            {
                using (SqlConnection sqlConexaoBanco = factory.ObterConexao())
                {
                    sqlConexaoBanco.Open();
                    string insert = "INSERT INTO Cliente (nome, email, cnpj, endereco) VALUES (@nome, @email, @cnpj, @endereco)";

                    SqlCommand comandoSql = new SqlCommand(insert, sqlConexaoBanco);
                    comandoSql.Parameters.AddWithValue("@nome", Nome);
                    comandoSql.Parameters.AddWithValue("@email", Email);
                    comandoSql.Parameters.AddWithValue("@cnpj", Cnpj);
                    comandoSql.Parameters.AddWithValue("@endereco", Endereco); // Adicionando o parâmetro para o endereço

                    comandoSql.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no banco de dados - método CadastrarCliente: " + ex.Message);
                return false;
            }
        }

        public SqlDataReader LocalizarCliente(ConexaoBanco factory)
        {
            SqlDataReader reader = null;
            try
            {
                using (SqlConnection sqlConexaoBanco = factory.ObterConexao())
                {
                    sqlConexaoBanco.Open();
                    string select = "SELECT id, nome, email, cnpj, endereco FROM Cliente WHERE cnpj = @cnpj"; // Incluindo o endereço na seleção
                    SqlCommand comandoSql = new SqlCommand(select, sqlConexaoBanco);
                    comandoSql.Parameters.AddWithValue("@cnpj", Cnpj);

                    reader = comandoSql.ExecuteReader(); // Retorna o SqlDataReader para o método chamar
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no banco de dados - método LocalizarCliente: " + ex.Message);
            }
            return reader;
        }

        public bool AtualizarCliente(ConexaoBanco factory)
        {
            try
            {
                using (SqlConnection sqlConexaoBanco = factory.ObterConexao())
                {
                    sqlConexaoBanco.Open();
                    string update = "UPDATE Cliente SET nome = @nome, email = @email, endereco = @endereco WHERE cnpj = @cnpj"; // Incluindo o endereço na atualização

                    SqlCommand comandoSql = new SqlCommand(update, sqlConexaoBanco);
                    comandoSql.Parameters.AddWithValue("@nome", Nome);
                    comandoSql.Parameters.AddWithValue("@email", Email);
                    comandoSql.Parameters.AddWithValue("@cnpj", Cnpj);
                    comandoSql.Parameters.AddWithValue("@endereco", Endereco); // Adicionando o parâmetro para o endereço

                    return comandoSql.ExecuteNonQuery() > 0; // Retorna true se a atualização foi bem-sucedida
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no banco de dados - método AtualizarCliente: " + ex.Message);
                return false;
            }
        }

        public bool DeletarCliente(ConexaoBanco factory)
        {
            try
            {
                using (SqlConnection sqlConexaoBanco = factory.ObterConexao())
                {
                    sqlConexaoBanco.Open();
                    string delete = "DELETE FROM Cliente WHERE cnpj = @cnpj";

                    SqlCommand comandoSql = new SqlCommand(delete, sqlConexaoBanco);
                    comandoSql.Parameters.AddWithValue("@cnpj", Cnpj);

                    return comandoSql.ExecuteNonQuery() > 0; // Retorna true se a exclusão foi bem-sucedida
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no banco de dados - método DeletarCliente: " + ex.Message);
                return false;
            }
        }

        // Novo método para obter todos os clientes
        public DataTable ObterTodosClientes(ConexaoBanco factory)
        {
            DataTable tabelaClientes = new DataTable();

            try
            {
                using (SqlConnection sqlConexaoBanco = factory.ObterConexao())
                {
                    sqlConexaoBanco.Open();
                    string select = "SELECT id, nome, email, cnpj, endereco FROM Cliente"; // Incluindo o endereço na seleção
                    SqlCommand comandoSql = new SqlCommand(select, sqlConexaoBanco);

                    SqlDataAdapter adapter = new SqlDataAdapter(comandoSql);
                    adapter.Fill(tabelaClientes);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao obter clientes: " + ex.Message);
            }

            return tabelaClientes;
        }
    }
}

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
        public string Endereco { get; set; }

        // Método para cadastrar cliente
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
                    comandoSql.Parameters.AddWithValue("@endereco", Endereco);
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

        // Método para localizar cliente com base no CNPJ
        public SqlDataReader LocalizarCliente(ConexaoBanco factory)
        {
            SqlDataReader reader = null;
            try
            {
                using (SqlConnection sqlConexaoBanco = factory.ObterConexao())
                {
                    sqlConexaoBanco.Open();
                    string select = "SELECT nome, email, cnpj, endereco FROM Cliente WHERE cnpj = @cnpj";
                    SqlCommand comandoSql = new SqlCommand(select, sqlConexaoBanco);
                    comandoSql.Parameters.AddWithValue("@cnpj", Cnpj);
                    reader = comandoSql.ExecuteReader();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no banco de dados - método LocalizarCliente: " + ex.Message);
            }
            return reader;
        }

        // Método para atualizar cliente
        public bool AtualizarCliente(ConexaoBanco factory)
        {
            try
            {
                using (SqlConnection sqlConexaoBanco = factory.ObterConexao())
                {
                    sqlConexaoBanco.Open();
                    string update = "UPDATE Cliente SET nome = @nome, email = @email, endereco = @endereco WHERE cnpj = @cnpj";
                    SqlCommand comandoSql = new SqlCommand(update, sqlConexaoBanco);
                    comandoSql.Parameters.AddWithValue("@nome", Nome);
                    comandoSql.Parameters.AddWithValue("@email", Email);
                    comandoSql.Parameters.AddWithValue("@cnpj", Cnpj);
                    comandoSql.Parameters.AddWithValue("@endereco", Endereco);
                    return comandoSql.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no banco de dados - método AtualizarCliente: " + ex.Message);
                return false;
            }
        }

        // Método para deletar cliente
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
                    return comandoSql.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no banco de dados - método DeletarCliente: " + ex.Message);
                return false;
            }
        }

        // Método para obter todos os clientes
        public DataTable ObterTodosClientes(ConexaoBanco factory)
        {
            DataTable tabelaClientes = new DataTable();

            try
            {
                using (SqlConnection sqlConexaoBanco = factory.ObterConexao())
                {
                    sqlConexaoBanco.Open();
                    string select = "SELECT nome, email, cnpj, endereco FROM Cliente";
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

        // Método para pesquisar clientes por nome ou CNPJ
        public DataTable PesquisarFuncionarios(ConexaoBanco factory, string pesquisa)
        {
            try
            {
                using (var connection = factory.ObterConexao())
                {
                    string query = "SELECT nome, email, cnpj, endereco FROM Cliente WHERE nome LIKE @Pesquisa OR cpf LIKE @Pesquisa";
                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Pesquisa", $"%{pesquisa}%");
                        using (var adapter = new SqlDataAdapter(command))
                        {
                            var dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            return dataTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao realizar a pesquisa: " + ex.Message);
                return null;
            }
        }
    }
}

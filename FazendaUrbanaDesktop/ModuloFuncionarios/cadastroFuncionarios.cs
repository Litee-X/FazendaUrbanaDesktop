using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Util.BD;

namespace FazendaUrbanaDesktop.ModuloFuncionarios
{
    public class CadastroFuncionarios
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
        public string Endereco { get; set; }

        // Método para cadastrar funcionário no banco de dados
        public bool CadastrarFuncionario(ConexaoBanco factory)
        {
            try
            {
                using (SqlConnection sqlConnection = factory.ObterConexao())
                {
                    sqlConnection.Open();
                    string insert = "INSERT INTO funcionarios (nome, email, cpf, endereco) VALUES (@Nome, @Email, @Cpf, @Endereco)";
                    using (SqlCommand comandoSql = new SqlCommand(insert, sqlConnection))
                    {
                        comandoSql.Parameters.AddWithValue("@Nome", Nome);
                        comandoSql.Parameters.AddWithValue("@Email", Email);
                        comandoSql.Parameters.AddWithValue("@Cpf", Cpf);
                        comandoSql.Parameters.AddWithValue("@Endereco", Endereco);
                        int rowsAffected = comandoSql.ExecuteNonQuery();
                        return rowsAffected > 0; // Retorna verdadeiro se a inserção for bem-sucedida
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no banco de dados - método CadastrarFuncionario: " + ex.Message);
                return false;
            }
        }

        // Método para verificar se o CPF já está cadastrado
        public bool CpfJaCadastrado(ConexaoBanco factory)
        {
            try
            {
                using (SqlConnection sqlConnection = factory.ObterConexao())
                {
                    sqlConnection.Open();
                    string select = "SELECT COUNT(*) FROM funcionarios WHERE cpf = @Cpf";
                    using (SqlCommand comandoSql = new SqlCommand(select, sqlConnection))
                    {
                        comandoSql.Parameters.AddWithValue("@Cpf", Cpf);
                        int count = (int)comandoSql.ExecuteScalar();
                        return count > 0; // Retorna true se o CPF já está cadastrado
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao verificar CPF no banco de dados: " + ex.Message);
                return false;
            }
        }

        // Método para atualizar funcionário no banco de dados
        public bool AtualizarFuncionarioPorCpf(ConexaoBanco factory)
        {
            try
            {
                using (SqlConnection sqlConnection = factory.ObterConexao())
                {
                    sqlConnection.Open();
                    string update = "UPDATE funcionarios SET nome = @Nome, email = @Email, endereco = @Endereco WHERE cpf = @Cpf";
                    using (SqlCommand comandoSql = new SqlCommand(update, sqlConnection))
                    {
                        comandoSql.Parameters.AddWithValue("@Nome", Nome);
                        comandoSql.Parameters.AddWithValue("@Email", Email);
                        comandoSql.Parameters.AddWithValue("@Endereco", Endereco);
                        comandoSql.Parameters.AddWithValue("@Cpf", Cpf);
                        int rowsAffected = comandoSql.ExecuteNonQuery();
                        return rowsAffected > 0; // Retorna verdadeiro se a atualização for bem-sucedida
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no banco de dados - método AtualizarFuncionarioPorCpf: " + ex.Message);
                return false;
            }
        }

        // Método para deletar funcionário pelo CPF
        public bool DeletarFuncionarioPorCpf(ConexaoBanco factory)
        {
            try
            {
                using (SqlConnection sqlConnection = factory.ObterConexao())
                {
                    sqlConnection.Open();
                    string delete = "DELETE FROM funcionarios WHERE cpf = @Cpf";
                    using (SqlCommand comandoSql = new SqlCommand(delete, sqlConnection))
                    {
                        comandoSql.Parameters.AddWithValue("@Cpf", Cpf);
                        int rowsAffected = comandoSql.ExecuteNonQuery();
                        return rowsAffected > 0; // Retorna verdadeiro se a exclusão for bem-sucedida
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no banco de dados - método DeletarFuncionarioPorCpf: " + ex.Message);
                return false;
            }
        }

        // Método para obter todos os funcionários
        public DataTable ObterTodosFuncionarios(ConexaoBanco factory)
        {
            try
            {
                using (var connection = factory.ObterConexao())
                {
                    using (var command = new SqlCommand("SELECT nome, email, cpf, endereco FROM funcionarios", connection))
                    {
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
                MessageBox.Show("Erro ao carregar todos os funcionários: " + ex.Message);
                return null;
            }
        }

        // Método para pesquisar funcionários por nome ou CPF
        public DataTable PesquisarFuncionarios(ConexaoBanco factory, string pesquisa)
        {
            try
            {
                using (var connection = factory.ObterConexao())
                {
                    string query = "SELECT nome, email, cpf, endereco FROM funcionarios WHERE nome LIKE @Pesquisa OR cpf LIKE @Pesquisa";
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
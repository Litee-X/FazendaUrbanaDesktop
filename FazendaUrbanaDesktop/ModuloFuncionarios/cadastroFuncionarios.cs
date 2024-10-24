using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Util.BD;

namespace FazendaUrbanaDesktop.ModuloFuncionarios
{
    internal class CadastroFuncionarios
    {
        private int id;
        private string nome;
        private string email;
        private string cpf;
        private string endereco;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }
        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }

        // Método para cadastrar funcionário no banco de dados
        public bool CadastrarFuncionarios(ConexaoBanco factory)
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

                        comandoSql.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no banco de dados - método CadastrarFuncionarios: " + ex.Message);
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

        // Método para localizar funcionário pelo CPF
        public DataRow LocalizarFuncionarioPorCpf(ConexaoBanco factory)
        {
            try
            {
                using (SqlConnection sqlConnection = factory.ObterConexao())
                {
                    sqlConnection.Open();

                    string select = "SELECT id, nome, email, cpf, endereco FROM funcionarios WHERE cpf = @Cpf";
                    using (SqlCommand comandoSql = new SqlCommand(select, sqlConnection))
                    {
                        comandoSql.Parameters.AddWithValue("@Cpf", Cpf);
                        using (SqlDataReader reader = comandoSql.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                DataTable dataTable = new DataTable();
                                dataTable.Load(reader);
                                return dataTable.Rows[0]; // Retorna a primeira linha encontrada
                            }
                        }
                    }
                }
                return null; // Nenhum funcionário encontrado
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no banco de dados - método LocalizarFuncionarioPorCpf: " + ex.Message);
                return null;
            }
        }

        // Método para atualizar funcionário pelo CPF
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

                        comandoSql.ExecuteNonQuery();
                    }
                }
                return true;
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
                        comandoSql.ExecuteNonQuery();
                    }
                }
                return true;
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
            using (var connection = factory.ObterConexao())
            {
                using (var command = new SqlCommand("SELECT id, nome, email, cpf, endereco FROM funcionarios", connection))
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
    }
}

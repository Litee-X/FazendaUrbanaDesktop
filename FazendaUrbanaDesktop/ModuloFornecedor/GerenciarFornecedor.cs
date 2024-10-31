using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Util.BD;

namespace FazendaUrbanaDesktop.ModuloFornecedor
{
    internal class GerenciarFornecedor
    {
        public string NomeFornecedor { get; set; }
        public string Email { get; set; }
        public string Cnpj { get; set; }
        public string Endereco { get; set; }

        public bool CadastrarFornecedor(ConexaoBanco factory)
        {
            try
            {
                using (SqlConnection sqlConexaoBanco = factory.ObterConexao())
                {
                    sqlConexaoBanco.Open();
                    string insert = "INSERT INTO Fornecedor (nome, email, cnpj, endereco) VALUES (@nome, @email, @cnpj, @endereco)";

                    SqlCommand comandoSql = new SqlCommand(insert, sqlConexaoBanco);
                    comandoSql.Parameters.AddWithValue("@nome", NomeFornecedor);
                    comandoSql.Parameters.AddWithValue("@email", Email);
                    comandoSql.Parameters.AddWithValue("@cnpj", Cnpj);
                    comandoSql.Parameters.AddWithValue("@endereco", Endereco);

                    comandoSql.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar fornecedor: " + ex.Message);
                return false;
            }
        }

        public SqlDataReader LocalizarFornecedor(ConexaoBanco factory)
        {
            SqlDataReader reader = null;
            try
            {
                using (SqlConnection sqlConexaoBanco = factory.ObterConexao())
                {
                    sqlConexaoBanco.Open();
                    string select = "SELECT nome, email, cnpj, endereco FROM Fornecedor WHERE cnpj = @cnpj OR nome = @nome";
                    SqlCommand comandoSql = new SqlCommand(select, sqlConexaoBanco);
                    comandoSql.Parameters.AddWithValue("@cnpj", Cnpj);
                    comandoSql.Parameters.AddWithValue("@nome", NomeFornecedor);

                    reader = comandoSql.ExecuteReader();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao localizar fornecedor: " + ex.Message);
            }
            return reader;
        }

        public bool AtualizarFornecedor(ConexaoBanco factory)
        {
            try
            {
                using (SqlConnection sqlConexaoBanco = factory.ObterConexao())
                {
                    sqlConexaoBanco.Open();
                    string update = "UPDATE Fornecedor SET nome = @nome, email = @email, endereco = @endereco WHERE cnpj = @cnpj";

                    SqlCommand comandoSql = new SqlCommand(update, sqlConexaoBanco);
                    comandoSql.Parameters.AddWithValue("@nome", NomeFornecedor);
                    comandoSql.Parameters.AddWithValue("@email", Email);
                    comandoSql.Parameters.AddWithValue("@cnpj", Cnpj);
                    comandoSql.Parameters.AddWithValue("@endereco", Endereco);

                    return comandoSql.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar fornecedor: " + ex.Message);
                return false;
            }
        }

        public bool DeletarFornecedor(ConexaoBanco factory)
        {
            try
            {
                using (SqlConnection sqlConexaoBanco = factory.ObterConexao())
                {
                    sqlConexaoBanco.Open();
                    string delete = "DELETE FROM Fornecedor WHERE cnpj = @cnpj";

                    SqlCommand comandoSql = new SqlCommand(delete, sqlConexaoBanco);
                    comandoSql.Parameters.AddWithValue("@cnpj", Cnpj);

                    return comandoSql.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir fornecedor: " + ex.Message);
                return false;
            }
        }

        public DataTable ObterTodosFornecedores(ConexaoBanco factory)
        {
            DataTable tabelaFornecedores = new DataTable();

            try
            {
                using (SqlConnection sqlConexaoBanco = factory.ObterConexao())
                {
                    sqlConexaoBanco.Open();
                    string select = "SELECT nome, email, cnpj, endereco FROM Fornecedor";
                    SqlCommand comandoSql = new SqlCommand(select, sqlConexaoBanco);

                    SqlDataAdapter adapter = new SqlDataAdapter(comandoSql);
                    adapter.Fill(tabelaFornecedores);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao obter fornecedores: " + ex.Message);
            }

            return tabelaFornecedores;
        }
    }
}
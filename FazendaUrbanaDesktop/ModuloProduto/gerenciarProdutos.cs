using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Util.BD;

namespace FazendaUrbanaDesktop.ModuloProduto
{
    public class GerenciarProdutos
    {
        public string NomeProduto { get; set; }
        public int Quantidade { get; set; }
        public DateTime DataPlantio { get; set; }

        public bool CadastrarProduto(ConexaoBanco factory)
        {
            try
            {
                using (SqlConnection sqlConexaoBanco = factory.ObterConexao())
                {
                    sqlConexaoBanco.Open();
                    string insert = "INSERT INTO produto (nome, quantidade, data_plantio) VALUES (@nome, @quantidade, @data_plantio)";

                    using (SqlCommand comandoSql = new SqlCommand(insert, sqlConexaoBanco))
                    {
                        comandoSql.Parameters.AddWithValue("@nome", NomeProduto);
                        comandoSql.Parameters.AddWithValue("@quantidade", Quantidade);
                        comandoSql.Parameters.AddWithValue("@data_plantio", DataPlantio);

                        comandoSql.ExecuteNonQuery();
                        return true; // Retorna true se a operação for bem-sucedida
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no banco de dados - método CadastrarProduto: " + ex.Message);
                return false; // Retorna false em caso de erro
            }
        }

        public DataTable LocalizarProduto(string nomeProduto, ConexaoBanco factory)
        {
            DataTable tabelaProdutos = new DataTable();
            try
            {
                using (SqlConnection sqlConexaoBanco = factory.ObterConexao())
                {
                    sqlConexaoBanco.Open();
                    string select = "SELECT nome, quantidade, data_plantio FROM produto WHERE nome LIKE @nome";
                    using (SqlCommand comandoSql = new SqlCommand(select, sqlConexaoBanco))
                    {
                        comandoSql.Parameters.AddWithValue("@nome", "%" + nomeProduto + "%");

                        SqlDataAdapter adapter = new SqlDataAdapter(comandoSql);
                        adapter.Fill(tabelaProdutos);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no banco de dados - método LocalizarProduto: " + ex.Message);
            }

            return tabelaProdutos;
        }

        public bool AtualizarProduto(string nomeProdutoAtual, int quantidadeAtual, ConexaoBanco factory)
        {
            try
            {
                using (SqlConnection sqlConexaoBanco = factory.ObterConexao())
                {
                    sqlConexaoBanco.Open();
                    string update = "UPDATE produto SET nome = @novoNome, quantidade = @novaQuantidade WHERE nome = @nomeAtual AND quantidade = @quantidadeAtual";

                    using (SqlCommand comandoSql = new SqlCommand(update, sqlConexaoBanco))
                    {
                        comandoSql.Parameters.AddWithValue("@novoNome", NomeProduto);
                        comandoSql.Parameters.AddWithValue("@novaQuantidade", Quantidade);
                        comandoSql.Parameters.AddWithValue("@nomeAtual", nomeProdutoAtual);
                        comandoSql.Parameters.AddWithValue("@quantidadeAtual", quantidadeAtual);

                        int linhasAfetadas = comandoSql.ExecuteNonQuery();
                        return linhasAfetadas > 0; // Retorna true se alguma linha foi atualizada
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no banco de dados - método AtualizarProduto: " + ex.Message);
                return false;
            }
        }

        public bool DeletarProduto(ConexaoBanco factory)
        {
            try
            {
                using (SqlConnection conn = factory.ObterConexao())
                {
                    conn.Open();
                    string sql = "DELETE FROM produto WHERE nome = @nome AND quantidade = @quantidade AND data_plantio = @data_plantio";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@nome", NomeProduto);
                        cmd.Parameters.AddWithValue("@quantidade", Quantidade);
                        cmd.Parameters.AddWithValue("@data_plantio", DataPlantio);
                        return cmd.ExecuteNonQuery() > 0; // Retorna true se a exclusão foi bem-sucedida
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir produto: " + ex.Message);
                return false;
            }
        }
    }
}

using System.Data.SqlClient;

namespace Util.BD
{
    public class ConexaoBanco
    {
        private readonly string _connectionString;

        public ConexaoBanco(string connectionString)
        {
            _connectionString = connectionString;
        }

        public SqlConnection ObterConexao()
        {
            return new SqlConnection(_connectionString);
        }
    }
}

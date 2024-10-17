using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FazendaUrbanaDesktop.ModuloFuncionarios;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;

namespace FazendaUrbanaDesktop.ModuloCliente
{
    internal class gerenciarCliente
    {
        private int id;
        private string nome;
        private string cpf;
        private string email;
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

        public bool cadastrarCliente()
        {
            try
            {
                MySqlConnection MysqlConexaoBanco = new MySqlConnection(ConexaoBanco.bancoServidor);
                MysqlConexaoBanco.Open();

                string insert = $"insert into cliente (nome,email,cpf,endereco) values ('{Nome}', '{Email}','{Cpf}','{Endereco}')";

                MySqlCommand comandoSql = MysqlConexaoBanco.CreateCommand();
                comandoSql.CommandText = insert;

                comandoSql.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                //mensagem de erro do banco de dados quando não for possível cadastrar usuários ou funcionários no banco
                //erro ligado ao banco de dados.
                MessageBox.Show("Erro no banco de dados - método cadastrarCliente: " + ex.Message);
                return false;
            }
        }

        public MySqlDataReader localizarCliente()
        {
            try
            {
                MySqlConnection MysqlConexaoBanco = new MySqlConnection(ConexaoBanco.bancoServidor);
                MysqlConexaoBanco.Open();

                string select = $"select id, nome, email, cpf, endereco from cliente where cpf = '{Cpf}';";
                MySqlCommand comandoSql = MysqlConexaoBanco.CreateCommand();
                comandoSql.CommandText = select;

                MySqlDataReader reader = comandoSql.ExecuteReader();
                return reader;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no banco de dados - método localizarCliente: " + ex.Message);
                return null;
            }
        }

        public bool atualizarCliente()
        {
            try
            {
                MySqlConnection MysqlConexaoBanco = new MySqlConnection(ConexaoBanco.bancoServidor);
                MysqlConexaoBanco.Open();

                string uptade = $"update cliente set email = '{Email}', endereco = '{Endereco}' where id = '{Id}';";
                MySqlCommand comandoSql = MysqlConexaoBanco.CreateCommand();
                comandoSql.CommandText = uptade;

                comandoSql.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no banco de dados - método atualizarCliente: " + ex.Message);
                return false;
            }
        }

        public bool deletarCliente()
        {
            try
            {
                MySqlConnection MysqlConexaoBanco = new MySqlConnection(ConexaoBanco.bancoServidor);
                MysqlConexaoBanco.Open();

                string delete = $"delete from cliente where id = '{Id}';";
                MySqlCommand comandoSql = MysqlConexaoBanco.CreateCommand();
                comandoSql.CommandText = delete;

                comandoSql.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro banco de dados - método deletarCliente " + ex.Message);
                return false;
            }
        }
    }
}

using FazendaUrbanaDesktop.ModuloFuncionarios;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Util.BD;

namespace FazendaUrbanaDesktop.ModuloCliente
{
    public partial class frmGerenciarCliente : Form
    {
        public frmGerenciarCliente(ConexaoBancoBD _factory)
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            string connectionString = "Server=localhost;Database=dbFuncionarios;User Id=root;Password=Hyago04102002@;";
            string query = "SELECT * FROM cliente"; // Modifique para a tabela que deseja exibir

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Carregando os dados no DataGridView
                    dgGerenciarCliente.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar dados: " + ex.Message);
                }
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtNome.Text.Equals("") && !txtEmail.Text.Equals("") && !mskCpf.Text.Equals("") && !txtEndereco.Text.Equals(""))
                {
                    gerenciarCliente cadCliente = new gerenciarCliente();
                    cadCliente.Nome = txtNome.Text;
                    cadCliente.Email = txtEmail.Text;
                    cadCliente.Cpf = mskCpf.Text;
                    cadCliente.Endereco = txtEndereco.Text;

                    if (cadCliente.cadastrarCliente())
                    {
                        MessageBox.Show($"O cliente {cadCliente.Nome} foi cadastradado com sucesso!");
                        txtNome.Clear();
                        txtEmail.Clear();
                        mskCpf.Clear();
                        txtEndereco.Clear();
                        txtNome.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível cadastrar cliente!");
                    }
                }
                else
                {
                    MessageBox.Show("Favor preencher todos os campos corretamentes!");
                    txtNome.Clear();
                    txtEmail.Clear();
                    mskCpf.Clear();
                    txtEndereco.Clear();
                    txtNome.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar cliente: " + ex.Message);
            }
        }

        private void bntPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!mskCpf.Text.Equals(""))
                {
                    gerenciarCliente cadCliente = new gerenciarCliente();
                    cadCliente.Cpf = mskCpf.Text;

                    MySqlDataReader reader = cadCliente.localizarCliente();

                    if (reader != null)
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();

                            lblId.Text = reader["id"].ToString();
                            txtNome.Text = reader["nome"].ToString();
                            txtEmail.Text = reader["email"].ToString();
                            txtEndereco.Text = reader["endereco"].ToString();

                        }
                        else
                        {
                            MessageBox.Show("Cliente não encontrado");
                            mskCpf.Clear();
                            txtEmail.Clear();
                            txtNome.Clear();
                            txtEndereco.Clear();
                            mskCpf.Focus();
                            lblId.Text = "";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Cliente não encontrado");
                        mskCpf.Clear();
                        txtEmail.Clear();
                        txtNome.Clear();
                        txtEndereco.Clear();
                        mskCpf.Focus();
                        lblId.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Favor preencher o campo CPF, para realizar a pesquisa!");
                    mskCpf.Clear();
                    txtEmail.Clear();
                    txtNome.Clear();
                    txtEndereco.Clear();
                    mskCpf.Focus();
                    lblId.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao encontrar o cliente: " + ex.Message);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            mskCpf.Clear();
            txtEmail.Clear();
            txtNome.Clear();
            txtEndereco.Clear();
            lblId.Text = "";
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!mskCpf.Text.Equals("") && !txtEmail.Text.Equals("") && !txtNome.Text.Equals("") && !txtEndereco.Text.Equals(""))
                {
                    gerenciarCliente cadCliente = new gerenciarCliente();
                    cadCliente.Id = int.Parse(lblId.Text);
                    cadCliente.Email = txtEmail.Text;
                    cadCliente.Endereco = txtEndereco.Text;

                    if (cadCliente.atualizarCliente())
                    {
                        MessageBox.Show("Os dados do cliente foram atualizadas com sucesso!");
                        mskCpf.Clear();
                        txtEmail.Clear();
                        txtNome.Clear();
                        txtEndereco.Clear();
                        mskCpf.Focus();
                        lblId.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível atualizar as informações do cliente");
                        mskCpf.Clear();
                        txtEmail.Clear();
                        txtNome.Clear();
                        txtEndereco.Clear();
                        mskCpf.Focus();
                        lblId.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Favor localizar o cliente que deseja atualizar as informações");
                    mskCpf.Clear();
                    txtEmail.Clear();
                    txtNome.Clear();
                    txtEndereco.Clear();
                    mskCpf.Focus();
                    lblId.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar dados do cliente: " + ex.Message);

            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!mskCpf.Text.Equals("") && !txtEmail.Text.Equals("") && !txtEndereco.Text.Equals("") && !txtNome.Text.Equals(""))
                {
                    gerenciarCliente cadCliente = new gerenciarCliente();
                    cadCliente.Id = int.Parse(lblId.Text);
                    if (cadCliente.deletarCliente())
                    {
                        MessageBox.Show("O cliente foi excluido com sucesso!");
                        mskCpf.Clear();
                        txtEmail.Clear();
                        txtNome.Clear();
                        txtEndereco.Clear();
                        lblId.Text = "";
                    }

                    else
                    {
                        MessageBox.Show("Não foi possível excluir o cliente");
                        mskCpf.Clear();
                        txtEmail.Clear();
                        txtNome.Clear();
                        txtEndereco.Clear();
                        lblId.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Favor pesquisar qual cliente deseja excluir");
                    mskCpf.Clear();
                    txtEmail.Clear();
                    txtNome.Clear();
                    txtEndereco.Clear();
                    mskCpf.Focus();
                    lblId.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir cliente: " + ex.Message);
            }
        }
    }
}
    



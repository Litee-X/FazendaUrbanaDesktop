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

namespace FazendaUrbanaDesktop
{
    public partial class frmFuncionarios : Form
    {
        public frmFuncionarios()
        {
            InitializeComponent();
        }



        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtNome.Text.Equals("") && !txtEmail.Text.Equals("") && !txtCpf.Text.Equals("") && !txtEndereco.Text.Equals(""))
                {
                    cadastroFuncionarios cadFuncionarios = new cadastroFuncionarios();
                    cadFuncionarios.Nome = txtNome.Text;
                    cadFuncionarios.Email = txtEmail.Text;
                    cadFuncionarios.Cpf = txtCpf.Text;
                    cadFuncionarios.Endereco = txtEndereco.Text;

                    if (cadFuncionarios.cadastrarFuncionarios())
                    {
                        MessageBox.Show($"O funcionário {cadFuncionarios.Nome} foi cadastradado com sucesso!");
                        txtNome.Clear();
                        txtEmail.Clear();
                        txtCpf.Clear();
                        txtEndereco.Clear();
                        txtNome.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível cadastrar Funcionário!");
                    }
                }
                else
                {
                    MessageBox.Show("Favor preencher todos os campos corretamentes!");
                    txtNome.Clear();
                    txtEmail.Clear();
                    txtCpf.Clear();
                    txtEndereco.Clear();
                    txtNome.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar funcionário: " + ex.Message);
            }
        }

        private void bntPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtCpf.Text.Equals(""))
                {
                    cadastroFuncionarios cadFuncionarios = new cadastroFuncionarios();
                    cadFuncionarios.Cpf = txtCpf.Text;

                    MySqlDataReader reader = cadFuncionarios.localizarFuncionario();

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
                            MessageBox.Show("Funcionário não encontrado");
                            txtCpf.Clear();
                            txtEmail.Clear();
                            txtNome.Clear();
                            txtEndereco.Clear();
                            txtCpf.Focus();
                            lblId.Text = "";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Funcionário não encontrado");
                        txtCpf.Clear();
                        txtEmail.Clear();
                        txtNome.Clear();
                        txtEndereco.Clear();
                        txtCpf.Focus();
                        lblId.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Favor preencher o campo CPF, para realizar a pesquisa!");
                    txtCpf.Clear();
                    txtEmail.Clear();
                    txtNome.Clear();
                    txtEndereco.Clear();
                    txtCpf.Focus();
                    lblId.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao encontrar o funcionário: " + ex.Message);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCpf.Clear();
            txtEmail.Clear();
            txtNome.Clear();
            txtEndereco.Clear();
            lblId.Text = "";
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtCpf.Text.Equals("") && !txtEmail.Text.Equals("") && !txtNome.Text.Equals("") && !txtEndereco.Text.Equals(""))
                {
                    cadastroFuncionarios cadFuncionarios = new cadastroFuncionarios();
                    cadFuncionarios.Id = int.Parse(lblId.Text);
                    cadFuncionarios.Email = txtEmail.Text;
                    cadFuncionarios.Endereco = txtEndereco.Text;

                    if (cadFuncionarios.atualizarFuncionario())
                    {
                        MessageBox.Show("Os dados do funcionário foram atualizadas com sucesso!");
                        txtCpf.Clear();
                        txtEmail.Clear();
                        txtNome.Clear();
                        txtEndereco.Clear();
                        txtCpf.Focus();
                        lblId.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível atualizar as informações do funcionário");
                        txtCpf.Clear();
                        txtEmail.Clear();
                        txtNome.Clear();
                        txtEndereco.Clear();
                        txtCpf.Focus();
                        lblId.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Favor localizar o funcionário que deseja atualizar as informações");
                    txtCpf.Clear();
                    txtEmail.Clear();
                    txtNome.Clear();
                    txtEndereco.Clear();
                    txtCpf.Focus();
                    lblId.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar dados do funcionário: " + ex.Message);

            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtCpf.Text.Equals("") && !txtEmail.Text.Equals("") && !txtEndereco.Text.Equals("") && !txtNome.Text.Equals(""))
                {
                    cadastroFuncionarios cadFuncionarios = new cadastroFuncionarios();
                    cadFuncionarios.Id = int.Parse(lblId.Text);
                    if (cadFuncionarios.deletarFuncionario())
                    {
                        MessageBox.Show("O funcionário foi excluido com sucesso!");
                        txtCpf.Clear();
                        txtEmail.Clear();
                        txtNome.Clear();
                        txtEndereco.Clear();
                        lblId.Text = "";
                    }
                
                    else
                    {
                        MessageBox.Show("Não foi possível excluir funcionário");
                        txtCpf.Clear();
                        txtEmail.Clear();
                        txtNome.Clear();
                        txtEndereco.Clear();
                        lblId.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Favor pesquisar qual funcionário deseja excluir");
                    txtCpf.Clear();
                    txtEmail.Clear();
                    txtNome.Clear();
                    txtEndereco.Clear();
                    txtCpf.Focus();
                    lblId.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir funcionário: " + ex.Message);
            }
        }
    }
}
    


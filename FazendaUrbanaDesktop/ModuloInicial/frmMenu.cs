using FazendaUrbanaDesktop.ModuloCliente;
using FazendaUrbanaDesktop.ModuloFuncionarios;
using FazendaUrbanaDesktop.ModuloProduto;
using FazendaUrbanaDesktop.ModuloUsuario;
using FazendaUrbanaDesktop.ModuloFornecedor;
using Util.BD;
using System.Windows.Forms;

namespace FazendaUrbanaDesktop.ModuloInicial
{
    public partial class frmMenu : Form
    {
        private readonly ConexaoBanco _factory;

        public frmMenu(ConexaoBanco factory)
        {
            InitializeComponent();
            _factory = factory;
        }

        private void gerenciarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            try
            {
                frmFuncionarios frmFuncionarios = new frmFuncionarios(_factory);
                frmFuncionarios.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void gerenciarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            try
            {
                frmGerenciarProduto frmGerenciarProduto = new frmGerenciarProduto(_factory);
                frmGerenciarProduto.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void gerenciarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                frmGerenciarCliente frmGerenciarCliente = new frmGerenciarCliente(_factory);
                frmGerenciarCliente.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void gerenciarToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            try
            {
                // Cria uma nova instância do formulário de cadastro de usuário
                frmCadastroUsuario frmCadastroUsuario = new frmCadastroUsuario(_factory);

                // Exibe o formulário
                frmCadastroUsuario.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void gerenciarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                // Cria uma nova instância do formulário de cadastro de usuário
                frmGerenciarFornecedor frmGerenciarFornecedor = new frmGerenciarFornecedor(_factory);

                // Exibe o formulário
                frmGerenciarFornecedor.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
    }
}

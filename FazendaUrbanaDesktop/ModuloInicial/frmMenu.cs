using FazendaUrbanaDesktop.ModuloCliente;
using FazendaUrbanaDesktop.ModuloFuncionarios;
using FazendaUrbanaDesktop.ModuloProduto;
using FazendaUrbanaDesktop.ModuloUsuario;
using FazendaUrbanaDesktop.ModuloFornecedor;
using Util.BD;
using System;
using System.Linq;
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

            this.IsMdiContainer = true;  // Define o frmMenu como MDI Container
            this.StartPosition = FormStartPosition.CenterScreen;  // Inicia a janela no centro da tela
            // Não definimos um tamanho fixo, ele usará o tamanho do Designer
        }

        // Método para fechar todas as janelas filhas antes de abrir uma nova
        private void FecharJanelasFilhas()
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();  // Fecha todas as janelas abertas
            }
        }

        // Método genérico para abrir um formulário filho
        private void AbrirFormulario(Form formulario)
        {
            // Fechar janelas filhas existentes antes de abrir uma nova
            FecharJanelasFilhas();

            // Define o MDI Parent e exibe o formulário
            formulario.MdiParent = this;
            formulario.Show();
        }

        // Evento para abrir o formulário de Gerenciamento de Produtos
        private void gerenciarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            try
            {
                frmGerenciarProduto frmGerenciarProduto = new frmGerenciarProduto(_factory);
                AbrirFormulario(frmGerenciarProduto);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        // Evento para abrir o formulário de Gerenciamento de Clientes
        private void gerenciarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                frmGerenciarCliente frmGerenciarCliente = new frmGerenciarCliente(_factory);
                AbrirFormulario(frmGerenciarCliente);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        // Evento para abrir o formulário de Cadastro de Usuário
        private void gerenciarToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            try
            {
                frmCadastroUsuario frmCadastroUsuario = new frmCadastroUsuario(_factory);
                AbrirFormulario(frmCadastroUsuario);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        // Evento para abrir o formulário de Gerenciamento de Fornecedores
        private void gerenciarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                frmGerenciarFornecedor frmGerenciarFornecedor = new frmGerenciarFornecedor(_factory);
                AbrirFormulario(frmGerenciarFornecedor);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        // Evento para abrir o formulário de Funcionários
        private void gerenciarToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            try
            {
                frmFuncionarios frmFuncionarios = new frmFuncionarios(_factory);
                AbrirFormulario(frmFuncionarios);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
    }
}

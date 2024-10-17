using FazendaUrbanaDesktop.ModuloCliente;
using FazendaUrbanaDesktop.ModuloFuncionarios;
//using FazendaUrbanaDesktop.ModuloUsuario;
//using Repository.Interface;
using Util.BD;

namespace FazendaUrbanaDesktop.ModuloInicial
{
    public partial class frmMenu : Form
    {
        private readonly ConexaoBancoBD _factory;
        //private readonly IClienteRepository _clienteRepository;
        //private readonly IUsuarioRepository _usuarioRepository;
        public frmMenu(ConexaoBancoBD factory)
        {
            InitializeComponent();
            _factory = factory;
        }

        private void gerenciarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmGerenciarCliente frmGerenciarCliente = new frmGerenciarCliente();

                // Exibe o formulário
                frmGerenciarCliente.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void gerenciarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmFuncionarios frmFuncionarios = new frmFuncionarios();

            // Exibe o formulário
            frmFuncionarios.Show();
        }
    }
}
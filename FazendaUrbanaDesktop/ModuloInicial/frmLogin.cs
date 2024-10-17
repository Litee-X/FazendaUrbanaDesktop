using Util.BD; 

namespace FazendaUrbanaDesktop.ModuloInicial
{
    public partial class frmLogin : Form
    {
        private readonly ConexaoBancoBD _factory;
        public frmLogin(ConexaoBancoBD factory)
        {
            InitializeComponent();
            _factory = factory;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            try
            {
                //implementar lógica

                this.Hide();
                frmMenu frmMenu = new frmMenu(_factory);
                frmMenu.Closed += (s, args) => this.Close();
                frmMenu.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
    }
}

using System;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using FazendaUrbanaDesktop.ModuloInicial;
using Util.BD; // Assegure-se de que este namespace est� correto

namespace FazendaUrbanaDesktop.Start
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Cria��o do servi�o de conex�o
            var serviceProvider = new ServiceCollection()
                .AddSingleton<ConexaoBanco>(new ConexaoBanco("Server=DESKTOP-3KC8UTG;Database=urbanFarm;User Id=sa;Password=Hyago04102002@;")) // Substitua pela sua string de conex�o
                .AddTransient<frmLogin>()
                .BuildServiceProvider();

            var mainForm = serviceProvider.GetRequiredService<frmLogin>();
            Application.Run(mainForm);
        }
    }
}

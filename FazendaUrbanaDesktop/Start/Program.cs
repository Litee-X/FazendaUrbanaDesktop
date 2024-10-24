using System;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using FazendaUrbanaDesktop.ModuloInicial;
using Util.BD; // Assegure-se de que este namespace está correto

namespace FazendaUrbanaDesktop.Start
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Criação do serviço de conexão
            var serviceProvider = new ServiceCollection()
                .AddSingleton<ConexaoBanco>(new ConexaoBanco("Server=DESKTOP-3KC8UTG;Database=urbanFarm;User Id=sa;Password=Hyago04102002@;")) // Substitua pela sua string de conexão
                .AddTransient<frmLogin>()
                .BuildServiceProvider();

            var mainForm = serviceProvider.GetRequiredService<frmLogin>();
            Application.Run(mainForm);
        }
    }
}

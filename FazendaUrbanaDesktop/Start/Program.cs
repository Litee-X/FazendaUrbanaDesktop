using FazendaUrbanaDesktop.ModuloInicial;
using Microsoft.Extensions.DependencyInjection;

namespace FazendaUrbanaDesktop.Start
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var serviceProvider = ServiceProviderBuilder.Build();
            var mainForm = serviceProvider.GetRequiredService<frmLogin>();
            Application.Run(mainForm);
        }
    }
}
using FazendaUrbanaDesktop.ModuloCliente;
using FazendaUrbanaDesktop.ModuloInicial;
using Microsoft.Extensions.DependencyInjection;
using System;
using Util.BD;

namespace FazendaUrbanaDesktop.Start
{
    public static class ServiceProviderBuilder
    {
        public static ServiceProvider Build()
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddTransient<frmGerenciarCliente>();
            serviceCollection.AddTransient<frmMenu>();
            serviceCollection.AddTransient<frmLogin>();
            serviceCollection.AddScoped<ConexaoBancoBD>();

            return serviceCollection.BuildServiceProvider();
        }
    }
}
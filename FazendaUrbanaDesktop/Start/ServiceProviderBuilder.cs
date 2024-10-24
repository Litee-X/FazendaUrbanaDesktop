using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

public static class ServiceProviderBuilder
{
    public static IServiceProvider Build(IConfiguration configuration)
    {
        var services = new ServiceCollection();

        // Registre suas dependências aqui
        // Por exemplo, se você tiver uma classe de conexão com o banco
        // services.AddSingleton<ConexaoBanco>(new ConexaoBanco(configuration.GetConnectionString("DefaultConnection")));

        return services.BuildServiceProvider();
    }
}

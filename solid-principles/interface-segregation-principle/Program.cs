using Microsoft.Extensions.DependencyInjection;
using interface_segregation_principle.Example1.Implementations;
using interface_segregation_principle.Example1.Interfaces;
using interface_segregation_principle.Example1.Services;

namespace example1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Configurar el contenedor de servicios
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);

            // Construir el proveedor de servicios
            var serviceProvider = serviceCollection.BuildServiceProvider();

            // Resolver y usar OfficeManager
            var officeManager = serviceProvider.GetRequiredService<OfficeManager>();
            officeManager.PerformOfficeTasks();
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            // Registrar los servicios y la clase dependiente en el contenedor
            services.AddTransient<Printer, LaserPrinter>(); // Cambiar a InkjetPrinter si es necesario
            services.AddTransient<Scanner, DocumentScanner>();
            services.AddTransient<OfficeManager>();
        }
    }
}

using Microondas_Digital.DAL.Data.Interfaces;
using Microondas_Digital.DAL.Data.Repositories;
using Microondas_Digital.Utils.Shared.Constants;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Microondas_Digital.UI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            var host = Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    services.AddScoped<IAcessoDadosRepository>(provider =>
                        new AcessoDadosRepository(SharedConstants.ConnectionString));

                    services.AddScoped<fmMicroondas>();
                    services.AddScoped<frmGerenciamentoProgramas>();
                })
                .Build();

            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                var form1 = services.GetRequiredService<fmMicroondas>();
                Application.Run(form1);
            }
        }
    }
}
using Microsoft.Extensions.DependencyInjection;
using RegistreSuaSerie.Interfaces;
using RegistreSuaSerie.Repositorios;
using System;

namespace RegistreSuaSerie
{
    public class Program
    {
        static void Main(string[] args)
        {
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);            

            var eventService = serviceCollection
                .BuildServiceProvider().GetService<IRegistreSuaSerie>();
            eventService.Execute();
        }

        private static void ConfigureServices(ServiceCollection serviceCollection) 
            => serviceCollection.AddScoped<IRegistreSuaSerie, RegistreSuaSerieAplicacao>()
                .AddScoped<ISeriesRepositorio, SeriesRepositorio>();

    }
}

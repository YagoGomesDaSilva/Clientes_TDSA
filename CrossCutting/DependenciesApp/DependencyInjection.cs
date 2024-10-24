using Domain.Abstractions;
using Infraestructure.Context;
using Infraestructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossCutting.DependenciesApp
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfraestructure(this IServiceCollection services, IConfiguration configuration) 
        {
            var ConectionString = configuration.GetConnectionString("AppDbConnectionStrings");

            services.AddDbContext<ApplicationDbContext>(options => options.UseMySql(
                ConectionString, 
                //x => x.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)
                ServerVersion.AutoDetect(ConectionString)
                )
            );

            //faz a injeção de dependencia
            services.AddScoped<IClienteRepository, ClienteRepository>();

            return services;
        }
    }
}

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UepaTicksWeb.Dominio.Context;
using UepaTicksWeb.Infraestructura.Interfaz.Services;
using UepaTicksWeb.Infraestructura.Interfaz.Repository;

namespace UepaTicksWeb.Infraestructura.IoCExtension
{
    public static class IoCExtensions
    {
        public static IServiceCollection ConfiguractionService(IServiceCollection services, IConfiguration configuration)
        {
            return services;
        }

        #region CONEXION AL MOTOR DE BASE DE DATOS
        public static IServiceCollection AddConexionDb(this IServiceCollection serviceCollection, IConfiguration configuration)
        {
            serviceCollection.AddDbContext<UepaTicksWebDbContext>(db =>
            {
                db.UseSqlServer("@Data Source=; Initial Catalog=; Integrated Security=True; MultipleActiveResultSets=True;", sqlDb =>
                {
                    sqlDb.EnableRetryOnFailure();
                    sqlDb.UseNetTopologySuite();

                });

                db.UseLazyLoadingProxies();
            });

            serviceCollection.AddScoped<UepaTicksWebDbContext>();

           return serviceCollection;
        }
        #endregion

        public static IServiceCollection AddServices(this IServiceCollection services) 
        {
            services.AddScoped<ITaquillasService, TaquilasService>();
            services.AddScoped(typeof(IEventosService), typeof(EventosService));
            services.AddScoped<IClientesService, ClientesService>();

            return services;
        }

    }

}

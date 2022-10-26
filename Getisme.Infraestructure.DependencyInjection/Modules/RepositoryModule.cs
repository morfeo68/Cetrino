using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MySQL.EntityFrameworkCore.Extensions;
using Getisme.Data.Interfaces;
using Getisme.Data.Repositories;
using Getisme.Data.Repositories.Context;


namespace Getisme.Infraestructure.DependencyInjection.Modules
{
    public class RepositoryModule
    {
        public static void Configure ( IServiceCollection services, IConfiguration configuration )
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection");
                services.AddDbContext<GetismeDBContext>(
                    options => options.UseMySql(
                        connectionString,
                        mysqloptions => mysqloptions.MigrationsAssembly("Getisme.Data.Repositories"
                    /*sqlserverOptions.MigrationsAssembly("BlogEngine.Data.Repositories"*/)));
        
            services.AddScoped<IRepositoryContext, GetismeDBContext>( );
            services.AddScoped<IAlmacen, AlmacenRepository>( );
            services.AddScoped<IConcepto, ConceptoRepository>( );
            services.AddScoped<IIVA,IVARepository>();
            services.AddScoped<ITipoDocumento,TipoDocumentoRepsitory>();
        }
    }
}
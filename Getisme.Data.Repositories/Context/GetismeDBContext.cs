using Getisme.Data.Interfaces;
using Getisme.Data.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Getisme.Data.Repositories.Context
{
    public class GDBContext:DbContext,IRepositoryContext,IDbContext
    {
        public GDBContext ( DbContextOptions<GDBContext> options ) : base(options)
        {
        }
        public DbSet<IVA> IVAs { get; set; }
        public DbSet<TipoDocumento> TipoDocumentos { get; set; }
        public DbSet<Concepto> Conceptos { get; set; }
        public DbSet<Almacen> Almacenes{get;set;}

        protected override void OnModelCreating ( ModelBuilder builder )
        {
            base.OnModelCreating(builder);
        }

        public async Task ReloadEntitiesAsync()
        {
            var entities = base.ChangeTracker.Entries( ).ToList( );
            foreach ( var entity in entities )
            {
                await entity.ReloadAsync( );
            }
        }
    }
}

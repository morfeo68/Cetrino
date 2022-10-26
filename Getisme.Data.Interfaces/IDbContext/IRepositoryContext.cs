using Microsoft.EntityFrameworkCore;
using Getisme.Data.Models.Entities;
//using Getisme.Data.Models.Interfaces;


namespace Getisme.Data.Interfaces
{
    public interface IRepositoryContext : IDbContext
    {
        DbSet<Almacen> Almacenes {get;set;}
        DbSet<Concepto>Conceptos{get;set;}
        DbSet<IVA>IVAs{get;set;}
        DbSet<TipoDocumento>TipoDocumentos{get;set;}


    }
}
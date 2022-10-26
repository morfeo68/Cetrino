using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Threading;
using System.Threading.Tasks;


namespace Getisme.Data.Interfaces
{
    public interface IDbContext:IDisposable
    {
        DbSet<TEntity> Set<TEntity> () where TEntity : class;
        Task<int> SaveChangesAsync ( CancellationToken cancellationToken = default(CancellationToken) );
        EntityEntry<TEntity> Entry<TEntity> ( TEntity entity ) where TEntity : class;
        Task ReloadEntitiesAsync ();


    }
}
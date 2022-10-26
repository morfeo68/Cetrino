using System;
using System.Collections.Generic;
using System.Threading.Tasks;




namespace Getisme.Data.Interfaces
{
    public interface IGenericRepository <T> where T : class
    {

        public Task<List<T>> GetAsync ();
        public T Add ( T entity );
        public Task GetItem ( int id );
        public Task UpdateAsync ( T entity );
        public  void DeleteAsync ( T entity );
        public Task GuardarCambiosAsync ();
        public Task<bool> ExistAsync ( int id );


    }


}
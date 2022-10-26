using System.ComponentModel.DataAnnotations;

namespace Getisme.Data.Models.Interfaces
{
    public interface IBase:IBaseEntity
    {
        
        public string Descripcion { get; set; }

        public bool Activo { get; set; }
    }
}

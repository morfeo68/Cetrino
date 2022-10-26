using Getisme.Data.Models.Interfaces;

namespace Getisme.Data.Models
{
    public interface IIVA : IBaseEntity,IBase
    {
       
        public float Tarifa{get;set;}

    }
}


namespace Getisme.Data.Models.Interfaces
{
    public interface IAlmacen:IBaseEntity,IBase
    {               
        public string NombreContacto {get;set;}
        public string ApellidoContacto{get;set;}
        public string Telefono{get;set;}
        public string TelMovil{get;set;}
        public string Direccion{get;set;}
        public string Poblacion{get;set;}
        public string CodPostal{get;set;}       
        public string Provincia{get;set;} 
        public string Notas{get;set;}

    }
}
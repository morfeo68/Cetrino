using Getisme.Data.Models.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Getisme.Data.Models.Entities
{
    public class Almacen:IAlmacen
    {
        [Key]
        public int Id{get;set;}

        [Display(Name ="Tienda/Almacén")]
        [Required(ErrorMessage ="Introduzca nombre tienda o almacén")]
        [StringLength(50,MinimumLength =3, ErrorMessage ="Mínimo 3 caracteres y máximo 50")]
        public string Descripcion{get;set;}

        [Display(Name ="Nombre")]
        [Required(ErrorMessage ="Introduzca nombre persona contacto")]
        [StringLength(50,MinimumLength =3, ErrorMessage ="Mínimo 3 caracteres y máximo 50")]
        public string NombreContacto {get;set;}

        [Display(Name ="Apellidos")]
        [Required(ErrorMessage ="Apellidos persona contacto")]
        [StringLength(50,MinimumLength =3, ErrorMessage ="Mínimo 3 caracteres y máximo 50")]
        public string ApellidoContacto{get;set;}

        [Display(Name ="Telefono fijo")]
        [DataType(DataType.PhoneNumber)]
        [StringLength(9,MinimumLength =9, ErrorMessage ="Mínimo 9 caracteres y máximo 9")]
        public string Telefono{get;set;}

        [Display(Name ="Telefono movil")]
        [Required(ErrorMessage ="Introduzca un número de telefono movil")]
        [DataType(DataType.PhoneNumber)]
        [StringLength(9,MinimumLength =9, ErrorMessage ="Mínimo 9 caracteres y máximo 9")]
        public string TelMovil{get;set;}
        

        [Display(Name ="Dirección")]
        [Required(ErrorMessage ="Introduzca una dirección")]
        [DataType(DataType.PhoneNumber)]
        [StringLength(50,MinimumLength =9, ErrorMessage ="Mínimo / caracteres y máximo 50")]
        public string Direccion{get;set;}

        [Display(Name ="Población")]
        [Required(ErrorMessage ="Introduzca una poblacion")]
        [DataType(DataType.PhoneNumber)]
        [StringLength(50,MinimumLength =2, ErrorMessage ="Mínimo 2 caracteres y máximo 50")]
        public string Poblacion{get;set;}

        [Display(Name ="Código Postal")]
        [Required(ErrorMessage ="Introduzca código postal")]
        [DataType(DataType.PostalCode)]
        [StringLength(5,MinimumLength =5, ErrorMessage ="Mínimo 5 digitos y máximo 5")]
        public string CodPostal{get;set;} 

        [Display(Name ="Provincia")]
        [Required(ErrorMessage ="Introduzca una provincia")]        
        [StringLength(50,MinimumLength =4, ErrorMessage ="Mínimo 4 caracteres y máximo 50")]
        public string Provincia{get;set;} 

        [DefaultValue(true)]
        public bool Activo{get;set;}
        
        public string Notas{get;set;}



    }
}
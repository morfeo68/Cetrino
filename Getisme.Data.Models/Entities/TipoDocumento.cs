using Getisme.Data.Models.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;


namespace Getisme.Data.Models.Entities
{
    public class TipoDocumento : IBaseEntity
    {   [Key]
        public int Id {get;set;}

        [Display(Name="NIF/NIE/Pasaporte")]
        [Required(ErrorMessage="Introduzca NIF/NIE/Pasaporte")]
        [StringLength(9, MinimumLength = 9, ErrorMessage = "Introduzca 8 digitos y una letra")]
        public string Descripcion  {get;set;}


        [DefaultValue(true)]
        public bool Activo {get;set;}
    }
}
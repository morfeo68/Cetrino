using Getisme.Data.Models.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Getisme.Data.Models.Entities
{
    public class Concepto:IConcepto
    {
        [Key]
        public int Id {get;set;}

        [Display(Name ="TConcepto")]
        [Required(ErrorMessage ="Introduzca un concepto")]
        [StringLength(250,MinimumLength =3, ErrorMessage ="Mínimo 7 caracteres y máximo 250")]
        public string Descripcion{get;set;}
        

        [DefaultValue(true)]
        public bool Activo{get;set;}

    }

}
using System.ComponentModel.DataAnnotations;

namespace WebAPI.DAL.Entities
{
    public class State : AuditBase
    {
        [Display(Name = "Estado/Departamento")] //Para identificar el nombre de la propiedad mas fácil
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener máximo {1} caracteres")] //Longitud max
        [Required(ErrorMessage = "Es campo {0} obligatorio")] //Campo obligatorio
        public string Name { get; set; }

        //Asi relaciono 2 tablas con EF core

        [Display(Name = "Pais")]
        public Country? Country { get; set; }

        //FK
        [Display(Name = "Id Pais")]
        public Guid CountryId { get; set; }
    }
}

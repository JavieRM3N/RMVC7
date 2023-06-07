using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ResidenciaMVC.Models
{
    public class CreacionSolicitudEntrada : IValidatableObject
    {
        [Required]
        [Display(Name = "Fecha Inicio")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        [DataType(DataType.Date)]
        public DateTime? StartDate { get; set; }

        [Required]
        [Display(Name = "Tipo Registro")]
        public int TipoRegistroId { get; set; }
        public SelectList TipoDRegistro { get; set; }

        [Display(Name = "Comentario")]
        public string Comentario { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            
            if (Comentario?.Length > 250)
            {
                yield return new ValidationResult("Comments are too long", new[] { nameof(Comentario) });
            }
        }


    }
}

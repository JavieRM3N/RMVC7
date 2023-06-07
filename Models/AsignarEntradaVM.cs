using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ResidenciaMVC.Models
{
    public class AsignarEntradaVM
    {
        [Required]
        public int Id { get; set; }

        [Display(Name = "Number Of Days")]
        [Required]
        [Range(1, 50, ErrorMessage = "Invalid Number Entered")]
        public int NumberOfDays { get; set; }

        public TipoEntradaVM? TipoEntrada { get; set; }

    }
}

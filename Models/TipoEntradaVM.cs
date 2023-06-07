using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ResidenciaMVC.Models
{
    public class TipoEntradaVM
    {
        public int Id { get; set; }

        [Display(Name = "Tipo de Entrada")]
        [Required]
        public string Name { get; set; }

        [Display(Name = "Numero Dias")]
        [Required]
        [Range(1, 25, ErrorMessage = "Please Enter A Valid Number")]
        public int DefaultDays { get; set; }

    }
}


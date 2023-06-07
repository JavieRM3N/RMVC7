using System.ComponentModel.DataAnnotations;

namespace ResidenciaMVC.Models
{
    public class ListaEmpleadoVM
    {
        public string Id { get; set; }

        [Display(Name = "Nombre")]
        public string Firstname { get; set; }

        [Display(Name = "Apellido")]
        public string Lastname { get; set; }

        [Display(Name = "Feca inicial de trabajo")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        [DataType(DataType.Date)]
        public DateTime DateJoined { get; set; }

        [Display(Name = "Email Address")]
        public string Email { get; set; }

    }
}

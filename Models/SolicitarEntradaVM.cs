using System.ComponentModel.DataAnnotations;

namespace ResidenciaMVC.Models
{
    public class SolicitarEntradaVM : CreacionSolicitudEntrada
    {
        
            public int Id { get; set; }

            [Display(Name = "Date Requested")]
            [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
            [DataType(DataType.Date)]
            public DateTime DateRequested { get; set; }

            [Display(Name = "Tipo Registro")]
            public TipoEntradaVM tipoentrada { get; set; }

            public bool? Aprobada { get; set; }
            public bool Cancelada { get; set; }

            public string? SoicitudEmpleadoId { get; set; }
            public ListaEmpleadoVM Empleado { get; set; }

            public int NumberOfDays { get; set; }
        

    }
}

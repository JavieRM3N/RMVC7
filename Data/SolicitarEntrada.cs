using System.ComponentModel.DataAnnotations.Schema;

namespace ResidenciaMVC.Data
{        
    public class SolicitarEntrada : BaseEntity
    {
            public DateTime StartDate { get; set; }
            public DateTime EndDate { get; set; }

            [ForeignKey("TipoEntradaId")]
            public TipoEntrada TipoEntrada { get; set; }
            public int TipoEntradaId { get; set; }

            public DateTime DateRequested { get; set; }
            public string? RequestComments { get; set; }

            public bool? Approved { get; set; }
            public bool Cancelled { get; set; }

            public string RequestingEmployeeId { get; set; }

     }

}
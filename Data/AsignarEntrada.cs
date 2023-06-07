using System.ComponentModel.DataAnnotations.Schema;

namespace ResidenciaMVC.Data
{
    public class AsignarEntrada : BaseEntity
    {
        public int NumberOfDays { get; set; }

        [ForeignKey("TipoEntradaId")]
        public TipoEntrada TipoEntrada{ get; set; }
        public int TipoEntradaId { get; set; }

        public string EmpleadoId { get; set; }

        public int Periodo { get; set; }
    }
}

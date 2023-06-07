using ResidenciaMVC.Data;

namespace ResidenciaMVC.Data
{
    public class TipoEntrada : BaseEntity
    {
        public string Name { get; set; }
        public int DefaultDays { get; set; }
    }
}

using Microsoft.AspNetCore.Identity;

namespace ResidenciaMVC.Data
{
    public class Empleado : IdentityUser
    {
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? TaxId { get; set; }
        public DateTime Fecha_Naciemiento { get; set; }
        public DateTime Fecha_Creacion { get; set; }
    }
    
}

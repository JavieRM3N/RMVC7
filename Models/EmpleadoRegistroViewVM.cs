namespace ResidenciaMVC.Models
{
    public class EmpleadoRegistroViewVM
    {
        public EmpleadoRegistroViewVM(List<AsignarEntradaVM> MiRegistro, List<SolicitarEntradaVM> MiSolicitud)
        {
            MisRegistros = MiRegistro;
            MisSolicitudes = MiSolicitud;
        }
        public List<AsignarEntradaVM> MisRegistros { get; set; }
        public List<SolicitarEntradaVM> MisSolicitudes { get; set; }

    }


}




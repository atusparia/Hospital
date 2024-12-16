using Hospital.Models;

namespace Hospital.Request
{
    public class HistoriaRequestV1
    {
        public DateTime FechaCreacion { get; set; }
        public int PacienteID { get; set; }        
        public bool? Activo { get; set; }
    }
}

using Hospital.Models;

namespace Hospital.Request
{
    public class CitaRequestV1
    {        
        //public int CitaID { get; set; }
        public DateTime Fecha { get; set; }
        public bool? Activo { get; set; }

        public int HistoriaClinicaID { get; set; }        
        public int EspecialidadID { get; set; }        
    }
}

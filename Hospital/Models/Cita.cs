namespace Hospital.Models
{
    public class Cita
    {
        public int CitaID { get; set; }
        public DateTime Fecha { get; set; }

        public bool? Activo { get; set; }

        public int HistoriaClinicaID { get; set; }
        public HistoriaClinica HistoriaClinica { get; set; }

        public int EspecialidadID { get; set; }
        public Especialidad Especialidad { get; set; }
    }
}

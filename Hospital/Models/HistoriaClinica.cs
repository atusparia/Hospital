namespace Hospital.Models
{
    public class HistoriaClinica
    {
        public int HistoriaClinicaID { get; set; }
        public DateTime FechaCreacion { get; set; }
        public int PacienteID { get; set; }
        public Paciente Paciente { get; set; }
        public bool? Activo { get; set; }
    }
}

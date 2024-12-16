namespace Hospital.Models
{
    public class HistoriaClinica
    {
        int HistoriaClinicaID { get; set; }
        DateTime FechaCreacion { get; set; }
        int PacienteID { get; set; }
        Paciente Paciente { get; set; }
        public bool? Activo { get; set; }
    }
}

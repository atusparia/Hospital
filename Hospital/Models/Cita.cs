namespace Hospital.Models
{
    public class Cita
    {
        public int CitaID { get; set; }
        public DateTime Fecha { get; set; }

        public bool? Activo { get; set; }

        public int PacienteID { get; set; }
        Paciente Paciente { get; set; }

        public int EspecialidadID { get; set; }
        Especialidad Especialidad { get; set; }
    }
}

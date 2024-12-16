namespace Hospital.Models
{
    public class Paciente
    {
        public int PacienteID { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Direccion { get; set; }
        public string Celular { get; set; }

        public DateTime FechaNacimiento { get; set; }
    }
}

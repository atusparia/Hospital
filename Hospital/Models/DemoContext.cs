using Microsoft.EntityFrameworkCore;

namespace Hospital.Models
{
    public class DemoContext:DbContext
    {
        public DbSet<HistoriaClinica> HistoriaClinicas { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }
        
        public DbSet<Especialidad> Especialidades { get; set; }

        public DbSet<Cita> Citas { get; set; }
        /*
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("data source = SRVMIO;" +
                    "initial catalog=HospitalDB; User Id=usMio; Pwd=Rcm123456;" +
                    "TrustServerCertificate=true");
        }*/

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("data source = UEI11;" +
                    "initial catalog=HospitalDB; User Id=sa; Pwd=Hrm260381;" +
                    "TrustServerCertificate=true");
        }
    }
}

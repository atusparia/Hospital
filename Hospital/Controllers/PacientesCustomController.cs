using Hospital.Models;
using Hospital.Responses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Hospital.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PacientesCustomController : ControllerBase
    {
        [HttpGet]
        public List<Paciente> Get()
        {
            using (var context = new DemoContext()) 
            { 
                return context.Pacientes.ToList();
            }
        }

        [HttpGet]
        public List<PacienteResponseV1> ListarPacientesDatos() {
            using (var context = new DemoContext()) 
            { 
                var pacientes = context.Pacientes.ToList();

                var response = pacientes.Select(x=> new PacienteResponseV1 { 
                    Nombres = x.Nombres,
                    Apellidos = x.Apellidos,
                    Celular = x.Celular,
                }).ToList();

                return response;
            }
        }

        [HttpPost]
        public void Insert(Paciente paciente)
        {
            using (var context = new DemoContext()) 
            {
                context.Pacientes.Add(paciente);
                context.SaveChanges();
            }
        }

        [HttpPut]
        public void Update(Paciente paciente) 
        {
            using (var context = new DemoContext())
            { 
                context.Entry(paciente).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        [HttpDelete]
        public void Delete(int PacienteId)
        {
            using (var context = new DemoContext())
            {
                var paciente = context.Pacientes.Find(PacienteId);
                context.Pacientes.Remove(paciente);
                context.SaveChanges();
            }
        }       
    }
}

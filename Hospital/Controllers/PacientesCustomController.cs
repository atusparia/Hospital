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

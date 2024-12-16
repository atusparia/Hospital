using Hospital.Models;
using Hospital.Request;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Hospital.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CitasCustomController : ControllerBase
    {
        [HttpPost]
        public void Insertar(Cita cita)
        {
            using (var context = new DemoContext())
            {
                context.Citas.Add(cita);
                context.SaveChanges();
            }
        }


        [HttpPost]
        public bool InsertarCita(CitaRequestV1 request)
        {
            try
            {
                using (var context = new DemoContext()) 
                {
                    Cita cita = new Cita
                    {
                        Fecha = DateTime.Now,
                        Activo = true,
                        HistoriaClinicaID = request.HistoriaClinicaID,
                        EspecialidadID = request.EspecialidadID,
                    };

                    context.Citas.Add(cita);
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex) 
            { 
                return false;
            }
        }
    }
}

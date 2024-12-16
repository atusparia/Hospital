using Hospital.Models;
using Hospital.Request;
using Hospital.Responses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hospital.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class HistoriasCustomController : ControllerBase
    {
        [HttpPost]
        public bool InsertarHistoria(HistoriaRequestV1 request)
        {
            try
            {
                using (var context = new DemoContext())
                {
                    HistoriaClinica historiaClinica = new HistoriaClinica
                    {
                        
                        FechaCreacion = DateTime.Now,
                        Activo = true,
                        PacienteID = request.PacienteID,                        
                    };

                    context.HistoriaClinicas.Add(historiaClinica);
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        [HttpPost]
        public ResponseBase InsertarConMensaje(HistoriaRequestV1 request)
        {
            ResponseBase response = new ResponseBase();

            try {
                using (var context = new DemoContext())
                {
                    HistoriaClinica historiaClinica = new HistoriaClinica
                    {
                        FechaCreacion = DateTime.Now,
                        Activo = true,
                        PacienteID = request.PacienteID,
                    };

                    context.HistoriaClinicas.Add(historiaClinica);
                    context.SaveChanges();

                    response.Mensaje = "Registro Exitoso";
                    response.CodigoError = 0;
                }
            }
            catch (Exception ex) 
            { 
                response.Mensaje = ex.ToString();
                response.CodigoError = -100;
            }
            return response;
        }
    }
}

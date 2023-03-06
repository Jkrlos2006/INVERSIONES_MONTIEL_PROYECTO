using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using IM_BACKEND._02_Logica;
using IM_BACKEND.DBInversionesMontiel;

namespace IM_BACKEND.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IngresoController : ControllerBase
    {
        IngresoLogica logica = new IngresoLogica();


        [HttpGet]
        public IActionResult get()
        {
            List<Ingreso> ingresos = logica.getAll();
            return Ok(ingresos);
        }


        [HttpGet("{ingreso_id}")]
        public IActionResult getById(int ingreso_id)
        {
            Ingreso ingreso = logica.getById(ingreso_id);
            return Ok(ingreso);
        }

        [HttpPost]

        public IActionResult create(Ingreso request)
        {
            Ingreso ingreso = logica.create(request);
            return Ok(ingreso);
        }


        [HttpPut]

        public IActionResult update(Ingreso request)
        {
            Ingreso ingreso = logica.update(request);
            return Ok(ingreso);
        }


        [HttpDelete("(ingreso_id)")]

        public IActionResult delete(int ingreso_id)
        {
            int cantidad = logica.delete(ingreso_id);
            return Ok(cantidad);
        }
    }
}

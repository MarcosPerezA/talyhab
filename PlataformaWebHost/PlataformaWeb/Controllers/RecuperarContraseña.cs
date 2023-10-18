using Microsoft.AspNetCore.Mvc;
using PlataformaWeb.Ingresos;
using PlataformaWeb.Recursos;

namespace PlataformaWeb.Controllers
{
    [Route("Contraseña/Recuperar")]
    [ApiController]
    public class RecuperarContraseña : ControllerBase
    {
        [HttpPost]
        public IActionResult EnviarCorreo([FromBody] EmailClave correo)
        {
            try
            {
                RecuperarClave recuperarClave = new RecuperarClave(correo.CorreoRecupera);
                return Ok("Registro Exitoso");
            }
            catch (Exception ex)
            {
                return BadRequest($"Error al enviar el correo: {ex.Message}");
            }
        }
    }
}

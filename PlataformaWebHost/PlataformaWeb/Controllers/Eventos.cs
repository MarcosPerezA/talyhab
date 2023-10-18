using Microsoft.AspNetCore.Mvc;
using PlataformaWeb.Ingresos;
using PlataformaWeb.Recursos;

namespace PlataformaWeb.Controllers
{
    [ApiController]
    [Route("Eventos")]
    public class Eventos : ControllerBase
    {
        [HttpPost]
        [Route("RegistroEvento")]
        public IActionResult Register([FromBody] DatosEventos eventos)
        {
            List<ParametrosEvento> parametros = new List<ParametrosEvento>
            {
                new ParametrosEvento("@Evento", eventos.Evento,"@correo",eventos.Correo,
                                      "@Nombre", eventos.Nombre,"@Genero",eventos.Genero,
                                      "@Telefono",eventos.Telefono)
            };
            registroEventos.registraEvento("registraEvento", parametros);

            return Ok("Registro Actualizado Con Exito");
        }

        [HttpPost]
        [Route("CorreoEvento")]
        public IActionResult EnviarCorreo([FromBody] EmailEvento evento)
        {
            try
            {
                registroEventos registroEventos = new registroEventos();
                registroEventos.correoEvento(evento.Email, evento.Evento ,evento.Nombre);
                return Ok("Correo enviado exitosamente");
            }
            catch (Exception ex)
            {
                return BadRequest($"Error al enviar el correo: {ex.Message}");
            }
        }

    }
}

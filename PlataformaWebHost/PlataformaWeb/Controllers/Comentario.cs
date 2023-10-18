using Microsoft.AspNetCore.Mvc;
using PlataformaWeb.Ingresos;
using PlataformaWeb.Recursos;

namespace PlataformaWeb.Controllers
{
    [ApiController]
    [Route("Comentarios")]
    public class Comentario : ControllerBase
    {
        [HttpPost]
        [Route("ingresaComentario")]
        public IActionResult Register([FromBody] DatosComentarios comentarios)
        {
            List<ParametrosComentarios> parametros = new List<ParametrosComentarios>
            {
                new ParametrosComentarios("@Nombre", comentarios.Nombre,"@Comentario",comentarios.Comentario
                                       )
            };
            Comentarios.ingresaComentario("insertaRecomendacion", parametros);

            return Ok("Registro Actualizado Con Exito");
        }

        [HttpGet]
        [Route("todosComentarios")]
        public IActionResult getProfiles()
        {

            Comentarios comentarios = new Comentarios();

            var result = comentarios.recuperaComentarios("recuperaRecomendacion");

            return Ok(result); // Devuelve la lista JSON como respuesta
        }


    }
}
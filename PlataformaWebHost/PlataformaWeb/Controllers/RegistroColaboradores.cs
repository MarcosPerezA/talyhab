using Microsoft.AspNetCore.Mvc;
using PlataformaWeb.Ingresos;
using PlataformaWeb.Recursos;

namespace PlataformaWeb.Controllers
{
    [ApiController]
    [Route("RegistroColaboradores")]
    public class RegistroColaboradores : ControllerBase
    {
        [HttpPost]
        [Route("Colaboradores")]
        public IActionResult Register([FromBody] DatosRegistros registros)
        {
            List<ParametrosRegistro> parametros = new List<ParametrosRegistro>
            {
                new ParametrosRegistro("@correo",registros.Email,"@usuario", registros.Usuario, "@clave", registros.Clave)
            };
            DatosRegistro.Ejecutar("registraColaborador", parametros);

            return Ok("Registro Exitoso");
        }
    }
}
using Microsoft.AspNetCore.Mvc;
using PlataformaWeb.Ingresos;
using PlataformaWeb.Recursos;

namespace PlataformaWeb.Controllers
{
    [ApiController]
    [Route("RegistroUsuarios")]
    public class RegistroUsuarios : ControllerBase
    {
        [HttpPost]
        [Route("RegistrosUsuarios")]
        public IActionResult Register([FromBody] DatosRegistros registros)
        {
            List<ParametrosRegistro> parametros = new List<ParametrosRegistro>
            {
                new ParametrosRegistro("@correo",registros.Email,"@usuario", registros.Usuario, "@clave", registros.Clave)
            };
            DatosRegistro.Ejecutar("registraUsuario", parametros);

            return Ok("Registro Exitoso");
        }
    }
}
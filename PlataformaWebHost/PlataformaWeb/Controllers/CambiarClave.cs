using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PlataformaWeb.Ingresos;
using PlataformaWeb.Recursos;
using System.Collections.Generic;
using System.Data;

namespace PlataformaWeb.Controllers
{
    [ApiController]
    [Route("Contraseña")]
    public class CambiarClave : ControllerBase
    {
        [HttpPost]
        [Route("Cambiar")]
        public IActionResult Ingreso([FromBody] ClaveNueva clave)
        {
            List<Parametro> parametros = new List<Parametro>
            {
                new Parametro("@correo", clave.Correo, "@claveNueva", clave.Clave)
            };

            DataTable tLogin = DatosLogin.Ejecutar("actualizaClave", parametros);
            string validacion = tLogin.Rows[0]["validacion"].ToString();
            string currentUrl = $"{Request.Scheme}://{Request.Host}{Request.Path}{Request.QueryString}";


            if (validacion == "1")
            {
                return Ok("Exito");
            }
            else
            {
                return Ok("Fallido");
            }
        }
    }
}

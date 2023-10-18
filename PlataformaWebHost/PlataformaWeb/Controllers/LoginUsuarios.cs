using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PlataformaWeb.Ingresos;
using PlataformaWeb.Recursos;
using System.Collections.Generic;
using System.Data;

namespace PlataformaWeb.Controllers
{
    [ApiController]
    [Route("Login")]
    public class LoginController : ControllerBase
    {
        [HttpPost]
        [Route("LoginUsuario")]
        public IActionResult Ingreso([FromBody] Credenciales credenciales)
        {
            List<Parametro> parametros = new List<Parametro>
            {
                new Parametro("@usuario", credenciales.Usuario, "@clave", credenciales.Clave)
            };

            DataTable tLogin = DatosLogin.Ejecutar("valida_login_usuario", parametros);
            string validacion = tLogin.Rows[0]["validacion"].ToString();
            string currentUrl = $"{Request.Scheme}://{Request.Host}{Request.Path}{Request.QueryString}";


            if (validacion == "1")
            {
                return Ok("acceso");
            }
            else
            {
                return Ok(new { Resultado = "Denegado", Url = currentUrl });
            }
        }
    }
}

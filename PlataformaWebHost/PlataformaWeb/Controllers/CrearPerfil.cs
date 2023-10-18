using Microsoft.AspNetCore.Mvc;
using PlataformaWeb.Ingresos;
using PlataformaWeb.Recursos;

namespace PlataformaWeb.Controllers
{
    [ApiController]
    [Route("Perfil")]
    public class CrearPerfil : ControllerBase
    {
        [HttpPost]
        [Route("EditaPerfil")]
        public IActionResult Register([FromBody] DatosPerfiles perfil)
        {
            List<ParametrosPerfil> parametros = new List<ParametrosPerfil>
            {
                new ParametrosPerfil("@Usuario",perfil.Usuario,"@Descripcion", perfil.Descripcion,"@puesto",perfil.Puesto, "@Aptitudes", perfil.Aptitudes,
                                       "@Nombre",perfil.Nombre,"@Foto", perfil.Foto
                                       )
            };
            DatosPerfil.editaPerfil("actualizaPerfil", parametros);

            return Ok("Registro Actualizado Con Exito");
        }

        [HttpPost]
        [Route("RecuperaPerfil")]
        public IActionResult getInfo([FromBody] DatosPerfiles.recuperaDatosPerfil datos)
        {
            List<ParametrosDatosPerfil> parametros = new List<ParametrosDatosPerfil>
             {
                 new ParametrosDatosPerfil("@usuario", datos.Usuario)
             };

            DatosPerfil datosPerfil = new DatosPerfil();

            var result = datosPerfil.recuperaDatos("recuperaDatos", parametros);

            return Ok(result); // Devuelve la lista JSON como respuesta
        }

        [HttpGet]
        [Route("todosPerfiles")]
        public IActionResult getProfiles()
        {

            DatosPerfil datosPerfil = new DatosPerfil();

            var result = datosPerfil.recuperaPerfiles("recuperaPerfiles");

            return Ok(result); // Devuelve la lista JSON como respuesta
        }


    }
}
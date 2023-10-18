using Microsoft.AspNetCore.Mvc;

namespace PlataformaWeb.Recursos
{
    public class ParametroClave
    {
        public ParametroClave(string nombre_correo, string correo, string nombre_pwd, string clave)
        {
            Correo = correo;
            Clave = clave;
            Nombre_Correo = nombre_correo;
            Nombre_pwd = nombre_pwd;
        }
        public string Correo { get; set; }
        public string Clave { get; set; }
        public string Nombre_Correo { get; set; }
        public string Nombre_pwd { get; set; }
    }
}

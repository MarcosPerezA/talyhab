namespace PlataformaWeb.Recursos
{
    public class ParametrosRegistro
    {
        public ParametrosRegistro(string nombre_usr, string usuario, string nombre_email, string email, string nombre_pwd, string clave)
        {
            Usuario = usuario;
            Clave = clave;
            Nombre_usr = nombre_usr;
            Nombre_pwd = nombre_pwd;
            Nombre_email = nombre_email;
            Email = email;
            
        }
        public string Usuario { get; set; }
        public string Clave { get; set; }
        public string Nombre_usr { get; set; }
        public string Nombre_pwd { get; set; }
        public string Email { get; set; }
        public string Nombre_email { get; set; }

    }
}

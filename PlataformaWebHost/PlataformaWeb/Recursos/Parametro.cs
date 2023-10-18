namespace PlataformaWeb.Recursos
{
    public class Parametro
    {
        public Parametro(string nombre_usr, string usuario, string nombre_pwd, string clave)
        {
            Usuario = usuario;
            Clave = clave;
            Nombre_usr = nombre_usr;
            Nombre_pwd = nombre_pwd;
        }
        public string Usuario { get; set; }
        public string Clave { get; set; }
        public string Nombre_usr { get; set; }
        public string Nombre_pwd { get; set; }
    }
}

namespace PlataformaWeb.Recursos
{
    public class ParametrosDatosPerfil
    {
        public ParametrosDatosPerfil(string n_usuario, string usuario)
        {
            N_Usuario = n_usuario;
            Usuario = usuario;
        }

        public string N_Usuario { get; set; }
        public string Usuario { get; set; }
    }
}

namespace PlataformaWeb.Recursos
{
    public class ParametrosPerfil
    {
        public ParametrosPerfil(string n_usuario, string usuario, 
                                string n_descripcion, string descripcion,
                                string n_puesto, string puesto,
                                string n_aptitudes, string aptitudes,
                                string n_nombre , string nombre,
                                string n_foto, string foto
                                )
        {
            Foto = foto;
            Descripcion = descripcion ;
            Aptitudes = aptitudes;
            Nombre = nombre;
            Usuario = usuario;
            Puesto = puesto;

             N_Foto         = n_foto;
             N_Descripcion  = n_descripcion;
             N_Aptitudes    = n_aptitudes;
             N_Nombre       = n_nombre;
             N_Usuario      = n_usuario;
             N_Puesto       = n_puesto;
    }

        public string Foto { get; set; }
        public string Descripcion { get; set; }
        public string Aptitudes { get; set; }
        public string Nombre { get; set; }
        public string Usuario { get; set; }
        public string Puesto { get; set; }

        public string N_Foto { get; set; }
        public string N_Descripcion { get; set; }
        public string N_Aptitudes { get; set; }
        public string N_Nombre { get; set; }
        public string N_Usuario { get; set; }
        public string N_Puesto { get; set; }
    }
}

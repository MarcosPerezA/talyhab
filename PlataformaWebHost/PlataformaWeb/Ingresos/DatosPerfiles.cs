namespace PlataformaWeb.Ingresos
{
    public class DatosPerfiles
    {
        public string Foto { get; set; }
        public string Descripcion { get; set; }
        public string Aptitudes { get; set; }
        public string Nombre { get; set; }
        public string Usuario { get; set; }
        public string Puesto { get; set; }

        public class recuperaDatosPerfil
        {
            public string Usuario { get; set; }
        }
    }
}

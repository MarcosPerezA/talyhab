namespace PlataformaWeb.Recursos
{
    public class ParametrosComentarios
    {
        public ParametrosComentarios(string n_nombre, string nombre, string n_comentario, string comentario)
        {
            N_Nombre = n_nombre;
            Nombre = nombre; 
            N_Comentario = n_comentario;
            Comentario = comentario;
            
        }
        public string N_Nombre { get; set; }
        public string Nombre { get; set; }
        public string N_Comentario { get; set; }
        public string Comentario { get; set; }

    }
}

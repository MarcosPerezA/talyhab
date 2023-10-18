namespace PlataformaWeb.Recursos
{
    public class ParametrosEvento
    {
        public ParametrosEvento(string n_evento, string evento,
                                string n_correo, string correo,
                                string n_nombre, string nombre,
                                string n_genero, string genero,
                                string n_telefono, string telefono) { 

            N_Evento = n_evento;
            Evento = evento;
            N_Correo = n_correo;
            Correo = correo;
            N_Nombre = n_nombre;
            Nombre= nombre;
            N_Genero = n_genero;
            Genero= genero;
            N_Telefono = n_telefono;
            Telefono= telefono;
   
        }


        public string N_Nombre { get; set; }
        public string Nombre { get; set; }
        public string N_Evento { get; set; }
        public string Evento { get; set; }
        public string N_Correo { get; set; }
        public string Correo { get; set; }
        public string N_Genero { get; set; }
        public string Genero { get; set; }
        public string N_Telefono { get; set; }
        public string Telefono { get; set; }
    }
}

using System.Data.SqlClient;
using System.Data;
using System.Net.Mail;
using System.Collections.Generic;

namespace PlataformaWeb.Recursos
{
    public class registroEventos
    {
        public static string cadenaConexion = "user=Marjosue12_SQLLogin_1;pwd=qbozh2ttw8;data source=Proyecto_Graduacion.mssql.somee.com;Initial Catalog=proyecto_graduacion;";
        public static DataTable registraEvento(string nombreProcedimiento, List<ParametrosEvento> parametros = null)
        {
            SqlConnection conexion = new SqlConnection(cadenaConexion);

            try
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand(nombreProcedimiento, conexion);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                if (parametros != null)
                {
                    foreach (var parametro in parametros)
                    {

                        cmd.Parameters.AddWithValue(parametro.N_Evento, parametro.Evento);
                        cmd.Parameters.AddWithValue(parametro.N_Correo, parametro.Correo);
                        cmd.Parameters.AddWithValue(parametro.N_Nombre, parametro.Nombre);
                        cmd.Parameters.AddWithValue(parametro.N_Genero, parametro.Genero);
                        cmd.Parameters.AddWithValue(parametro.N_Telefono, parametro.Telefono);
                    }
                }
                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);


                return tabla;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                conexion.Close();
            }
        }

        public static String correoEvento(string correoDestino, string evento, string nombre)
        {

            string EmailOrigen = "PG2Recupera@outlook.com";
            string Clave = "Cuilapa2023.";
            string Mensaje = "<b>Hola, "+nombre+" Tu Registro en el evento "+evento+" Se ha confirmado Con Exito.\n Te Esperamos alli.";

            MailMessage oMailMessage = new MailMessage(EmailOrigen, correoDestino, "Registro Evento "+evento, Mensaje);
            oMailMessage.IsBodyHtml = true;

            SmtpClient smtpClient = new SmtpClient("smtp-mail.outlook.com");
            smtpClient.EnableSsl = true;
            smtpClient.UseDefaultCredentials = false;
            // smtpClient.Host = "smtp.gmail.com";
            smtpClient.Port = 587;
            smtpClient.Credentials = new System.Net.NetworkCredential(EmailOrigen, Clave);
            smtpClient.Send(oMailMessage);

            smtpClient.Dispose();

            return "Exito";

        }
    }

}

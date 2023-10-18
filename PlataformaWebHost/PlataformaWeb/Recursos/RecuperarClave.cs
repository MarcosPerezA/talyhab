using PlataformaWeb.Ingresos;
using System.Net.Mail;

namespace PlataformaWeb.Recursos
{
    public class RecuperarClave
    {
        public RecuperarClave(string correoDestino) {

            string EmailOrigen = "PG2Recupera@outlook.com";
            string Clave = "Cuilapa2023.";
            string Mensaje = "<b>Hola si Se te olvido tu contraseña y deseas recuperarla, por favor ingresa al siguiente link:</b> http://127.0.0.1:5500/cambiarClave.html";

            MailMessage oMailMessage = new MailMessage(EmailOrigen, correoDestino, "Recuperar Contraseña", Mensaje);
            oMailMessage.IsBodyHtml = true;

            SmtpClient smtpClient = new SmtpClient("smtp-mail.outlook.com");
            smtpClient.EnableSsl = true;
            smtpClient.UseDefaultCredentials = false;
            // smtpClient.Host = "smtp.gmail.com";
            smtpClient.Port = 587;
            smtpClient.Credentials = new System.Net.NetworkCredential(EmailOrigen, Clave);
            smtpClient.Send(oMailMessage);

            smtpClient.Dispose();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoColaborativo2.Logica.General
{
    class clEnvio
    {
        public string usurioEnvio { get; set; }
        public string contraseñaEnvio { get; set;}

        public string correoReceptor { get; set; }

        public string correoCopia { get; set; }

        public  string asunto { get; set; }

        public string mensaje { get; set; }

        public string host { get; set; }
        public int port { get; set; }

        public Boolean enablessl { get; set; }

        public void mtdEnvioCorreo()
        {
            if (host == null && port == 0)
            {
                host = "smtp.gmail.com";
                port = 587;
            }
            try
            {
                System.Net.Mail.MailMessage ObjMensaje = new System.Net.Mail.MailMessage();
                ObjMensaje.To.Add(correoReceptor);
                ObjMensaje.Subject = asunto;
                ObjMensaje.SubjectEncoding = System.Text.Encoding.UTF8;
                ObjMensaje.Bcc.Add(correoCopia);
                ObjMensaje.Body = mensaje;
                ObjMensaje.BodyEncoding = System.Text.Encoding.UTF8;
                ObjMensaje.IsBodyHtml = true;
                ObjMensaje.From = new System.Net.Mail.MailAddress(usurioEnvio);

                System.Net.Mail.SmtpClient cliente = new System.Net.Mail.SmtpClient();
                cliente.Credentials = new System.Net.NetworkCredential(usurioEnvio, contraseñaEnvio);
                cliente.Port = port;//puerto de correo
                cliente.EnableSsl = true;
               // cliente.EnableSsl = true;// security socket 
                cliente.Host = host;// servidor de correo
                try
                {
                    cliente.Send(ObjMensaje);
                    MessageBox.Show("Mensaje Enviado Exitosamente ", "Su Mensaje ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception y)
                {
                    MessageBox.Show("No se pudo enviar el mensaje"+y);

                }
            }
            catch (Exception X)
            {
                MessageBox.Show("Hubo un error al contactar con el servidor", "ERROR " + X, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }

           
           


        }


    }
}

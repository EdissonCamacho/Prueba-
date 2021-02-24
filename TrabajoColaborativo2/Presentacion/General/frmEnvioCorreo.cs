using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoColaborativo2.Logica.General;

namespace TrabajoColaborativo2.Presentacion.General
{
    public partial class frmEnvioCorreo : Form
    {
        public frmEnvioCorreo()
        {
            InitializeComponent();
            grpInterfaz.Visible = false;
            grpAjustes.Visible = false;
            txtHost.Text = "smtp.gmail.com";
            txtPort.Text = "587";
        }

        clEnvio objEnvio = new clEnvio();
        private void btnUsar_Click(object sender, EventArgs e)
        {
            grInicioSesion.Visible = false;
            grpInterfaz.Visible = true;
            objEnvio.usurioEnvio = txtUsuarioEnvio.Text;
            objEnvio.contraseñaEnvio = txtContraseñaEnvio.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            objEnvio.correoReceptor = txtPara.Text;
            objEnvio.correoCopia = txtCopia.Text;
            objEnvio.asunto = txtAsunto.Text;
            objEnvio.mensaje = txtMensaje.Text;
            objEnvio.mtdEnvioCorreo();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            grpAjustes.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        { 
            objEnvio.host = txtHost.Text;
            objEnvio.port = int.Parse(txtPort.Text);
            grpAjustes.Visible = false;
          /* if (rbdNo.Checked==true)
            {
                objEnvio.enablessl = false;
            }
         //   else if (rbdSi.Checked==true)
            {
                objEnvio.enablessl = true;
            }*/

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtPara.Clear();
            txtCopia.Clear();
            txtAsunto.Clear();
            txtMensaje.Clear();
        }

        private void frmEnvioCorreo_Load(object sender, EventArgs e)
        {

        }
    }
}

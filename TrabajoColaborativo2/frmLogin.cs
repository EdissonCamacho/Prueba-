using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoColaborativo2.Logica;
using TrabajoColaborativo2.Presentacion;

namespace TrabajoColaborativo2
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
           BackColor = Color.Lime;
            TransparencyKey = Color.Lime;
            txtPassw.BackColor = Color.Black;
            txtUsuario.BackColor = Color.Black;
            // groupBox1.BackColor = Color.Transparent;
            imgError.Visible = false;
            imgUser.Visible = true;


        }
        clLogin objLogin = new clLogin();
        frmInformacion objFrmInformacion = new frmInformacion();

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            objLogin.usuario = txtUsuario.Text;
            objLogin.contraseña = txtPassw.Text;
            if(objLogin.mtdLogin() == true)
            {
                objFrmInformacion.Show();
                this.Hide();
            }
            lblMensaje.Text = objLogin.mensaje;
            if (lblMensaje.Text== "No quedan mas intentos")
            {
                imgError.Visible = true;
                imgUser.Visible = false;
                pnResultado.BackColor = Color.Red;
                MessageBox.Show("Programa Bloqueado");
                Application.Exit();

            }

            
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
           
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoColaborativo2.Logica.Ejercios_Algoritmos;

namespace TrabajoColaborativo2.Presentacion.Ejercicios_Secuenciales
{
    public partial class frmCondicionales : Form
    {
        public frmCondicionales()
        {
            InitializeComponent();
        }

        clCondicionales objLogicaCondicionales = new clCondicionales();

        private void btnComrpobar_Click(object sender, EventArgs e)
        {
            objLogicaCondicionales.edad = int.Parse(txtEdad.Text);
            objLogicaCondicionales.nivelEducativo = cmbEstudios.SelectedIndex;
            objLogicaCondicionales.puntajeEntrevista = double.Parse(txtEntrevista.Text);
            objLogicaCondicionales.mtdComprobarAprobacion();

        }

        private void frmCondicionales_Load(object sender, EventArgs e)
        {
            cmbEstudios.Items.Add("Si");
            cmbEstudios.Items.Add("No");
         /* //  this.BackColor = Color.FromArgb(0, 3, 6);// fondo color
            btnComrpobar.BackColor = Color.FromArgb(10, 184, 250);//cambia color boton
            btnComrpobar.ForeColor = Color.White;
            grpEjercicio1.BackColor = Color.White;
            txtTitulo.ForeColor = Color.White;
            btnComrpobar.FlatAppearance.BorderSize = 0;
            btnComrpobar.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);*/





        }

   
        private void btnvalordepago_Click(object sender, EventArgs e)
        {
            objLogicaCondicionales.horasTrabajadas = int.Parse(txtHoras.Text);
            objLogicaCondicionales.mtdHorasapagar();
            lblHorasPagar.Text = "$"+objLogicaCondicionales.valorApagar.ToString();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}

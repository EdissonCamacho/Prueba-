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
    public partial class frmSecuenciales : Form
    {
        public frmSecuenciales()
        {
            InitializeComponent();
            
        }

        clSecuenciales objSecuenciales = new clSecuenciales();
        


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            objSecuenciales.notasParciales = double.Parse(txtNotasParcial.Text);
            objSecuenciales.mtdAgregarNota();
            

        }

        private void txtCalcular_Click(object sender, EventArgs e)
        {
            objSecuenciales.notaP =double.Parse( txtNotaP.Text);
            objSecuenciales.notaE = double.Parse(txtExposicion.Text);
            objSecuenciales.mtdCalcular();
            MessageBox.Show("Las nota final es :" + objSecuenciales.total.ToString(), "La Nota Final", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        { 
            objSecuenciales.mtdLimpiar();
            txtCalcular.Text = "";
            txtExposicion.Text = "";
            txtNotaP.Text = "";
            txtNotasParcial.Text = "";
            


        }

        private void btnCalcularpresupuesto_Click(object sender, EventArgs e)
        {
            objSecuenciales.ValorMonetario = double.Parse(txtValorMonetario.Text);
            objSecuenciales.mtdPresupuesto();
            txtUrgen.Text = objSecuenciales.Urgencias.ToString();
            txtPediatria.Text = objSecuenciales.Pediatria.ToString();
            txtTraumatologia.Text = objSecuenciales.Traumatologia.ToString();
            




        }
    }
}

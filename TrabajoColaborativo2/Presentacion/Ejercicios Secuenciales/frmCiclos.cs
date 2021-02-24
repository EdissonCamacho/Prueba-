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
    public partial class frmCiclos : Form
    {
        public frmCiclos()
        {
            InitializeComponent();
        }
        clCiclos objCiclos = new clCiclos();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void frmCiclos_Load(object sender, EventArgs e)
        {

        }

        private void btnSumando_Click(object sender, EventArgs e)
        {
            
            objCiclos.Numero = int.Parse(txtN.Text);
            
            objCiclos.mtdSumando();
            txtTotal.Text = objCiclos.SumaTotal.ToString();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // objCiclos.Tnumero = int.Parse(txtBox1.Text);
            objCiclos.mtdResultado();
          //  txtbox4.Text = objCiclos.Total.ToString();

        }

        private void btnResultado1_Click(object sender, EventArgs e)
        {
            objCiclos.Numero3 = int.Parse(txtNumero3.Text);
            objCiclos.limite = int.Parse(txtlimite.Text);
            objCiclos.mtdResultadoop();
            txtnu.Text = objCiclos.Resultado4.ToString();
        }

        
    }

}

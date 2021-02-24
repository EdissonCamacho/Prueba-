using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoColaborativo2.Logica.Archivos_Planos.txt;

namespace TrabajoColaborativo2.Presentacion.Archivos_Planos.txt
{
    public partial class frmVerDatosTXT : Form
    {
        public frmVerDatosTXT()
        {
            InitializeComponent();
        }

        clLogicaRegistrar objTXT = new clLogicaRegistrar();
        private void btnVerDatos_Click(object sender, EventArgs e)
        {
            rtbMostrarDatos.Text = objTXT.mtdMostrarDatos();
        }
    }
}

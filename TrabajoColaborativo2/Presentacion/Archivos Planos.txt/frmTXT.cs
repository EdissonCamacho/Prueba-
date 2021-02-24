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
    public partial class frmTXT : Form
    {
        public frmTXT()
        {
            InitializeComponent();
        }

        clLogicaRegistrar objRegitrar = new clLogicaRegistrar();

        private void button1_Click(object sender, EventArgs e)
        {
            objRegitrar.documento = txtDocumento.Text;
            objRegitrar.nombres = txtNombres.Text;
            objRegitrar.apellidos = txtApellidos.Text;
            objRegitrar.fecha = dtpFecha.Value.Date.ToString("dd-MM-yyyy");
            objRegitrar.genero = cmbGenero.Text;
            objRegitrar.email = txtEmail.Text;
            objRegitrar.celular = long.Parse(txtCelular.Text);
            objRegitrar.mtdRegistrarDatos();

            mtdLimpiar();
        }

        private void mtdLimpiar()
        {
            txtDocumento.Text="";
            txtNombres.Text="";
            txtApellidos.Text="";
            cmbGenero.Text="";
            txtEmail.Text="";
            txtCelular.Text="";
        }
    }
}

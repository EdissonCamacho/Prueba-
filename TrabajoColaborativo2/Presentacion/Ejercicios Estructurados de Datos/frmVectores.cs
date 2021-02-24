using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoColaborativo2.Logica.Ejercicios_Estructurados_de_Datos;

namespace TrabajoColaborativo2.Presentacion.Ejercicios_Estructurados_de_Datos
{
    public partial class frmVectores : Form
    {
        private clLogicaVectores objLogicaVectores = new clLogicaVectores();
        public frmVectores()
        {
            InitializeComponent();
        }

        public void mtdLimpiar()
        {
            rtbVerDatos.Text = "";
            txtDocumento.Text = "";
            txtNombres.Text = "";
            txtBuscar.Text = "";
            btnAgregar.Enabled = true;
            txtDocumento.Enabled = true;
            txtNombres.Enabled = true;
            btnVerDatos.Enabled = true;
            rtbVerDatos.Enabled = true;
            btnOrdenar.Enabled = true;
            cmbTipoDatos.Enabled = true;
            btnBuscar.Enabled = true;
            txtBuscar.Enabled = true;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            if (txtTamaño.Text == "")
            {
                MessageBox.Show("Campo vacío");
            }
            else
            {
                objLogicaVectores.mtdNuevoVector(int.Parse(txtTamaño.Text));
                mtdLimpiar();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if ((txtDocumento.Text == "") || (txtNombres.Text == ""))
            {
                MessageBox.Show("Campo vacío");
            }
            else
            {
                objLogicaVectores.mtdCargarVector(int.Parse(txtDocumento.Text), txtNombres.Text);
                txtDocumento.Text = "";
                txtNombres.Text = "";
            }
        }

        private void btnVerDatos_Click(object sender, EventArgs e)
        {
            rtbVerDatos.Text = objLogicaVectores.mtdMostrarVector();
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            objLogicaVectores.mtdOrdenarVector();
            rtbVerDatos.Text = objLogicaVectores.mtdMostrarVector();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "" || cmbTipoDatos.Text == "")
            {
                MessageBox.Show("Campo vacío");
            }
            else
            {
                rtbVerDatos.Text = objLogicaVectores.mtdBuscarVector(cmbTipoDatos.SelectedIndex, txtBuscar.Text);
            }
        }
    }
}

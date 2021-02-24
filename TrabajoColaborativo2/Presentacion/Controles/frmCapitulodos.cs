using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoColaborativo2.Presentacion.Ejercicios_Secuenciales
{
    public partial class frmCapitulodos : Form
    {
        public frmCapitulodos()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            lblMensaje.Text = mtxDato.Text;
            mtdMostrarDatos();

        }

        public void mtdMostrarDatos()
        {
            ListViewGroup Celular = new ListViewGroup(" marca celular", HorizontalAlignment.Left);
            ListViewGroup marcacomputador = new ListViewGroup("Marca de computador", HorizontalAlignment.Left);


            lstvDispositivos.Items.Add(new ListViewItem("LG", Celular));
            lstvDispositivos.Items.Add(new ListViewItem("HUAWEI", Celular));
            lstvDispositivos.Items.Add(new ListViewItem("SAMSUNG", Celular));
            lstvDispositivos.Items.Add(new ListViewItem("MOTOROLA", Celular));
            lstvDispositivos.Items.Add(new ListViewItem("APPLE", Celular));

            ListViewItem Elemento = new ListViewItem("LENOVO", marcacomputador);
            lstvDispositivos.Items.Add(Elemento);

            lstvDispositivos.Items.Add(new ListViewItem("HP", marcacomputador));
            lstvDispositivos.Items.Add(new ListViewItem("APPLE", marcacomputador));
            lstvDispositivos.Items.Add(new ListViewItem("ASUS", marcacomputador));
            lstvDispositivos.Items.Add(new ListViewItem("TOSHIBA", marcacomputador));
            lstvDispositivos.Items.Add(new ListViewItem("ACER", marcacomputador));
            lstvDispositivos.Groups.Add(Celular);
            lstvDispositivos.Groups.Add(marcacomputador);
        }

        private void lstvDispositivos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void btnagregar_Click(object sender, EventArgs e)
        {
            this.lstNombre.Items.Add(this.txtnombre.Text);
            this.txtnombre.Clear();
            this.txtnombre.Focus();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            this.lstNombre.Items.Clear();
            this.lstNombre.Focus();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            this.lstNombre.Items.Remove(this.lstNombre.SelectedItem);
            this.txtnombre.Focus();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Los Datos del Estudiante son:" + "\nNombre: " + txtnombre.Text + "\nGrado: " + numericUpDown3.Value + "\nPromedio: " + numericUpDown2.Value + "\nEdad: " + numericUpDown1.Value);
        }

        private void btnNodo_Click(object sender, EventArgs e)
        {
            treev23.Nodes.Add (txtbox5.Text);
            txtbox5.Text="";
        }

        private void btnnodo2_Click(object sender, EventArgs e)
        {
            treev23.SelectedNode.Nodes.Add(txtbox6.Text);
            txtbox6.Text="";
        }

        private void btnb_Click(object sender, EventArgs e)
        {
            treev23.Nodes.Clear();
        }

        private void btneli_Click(object sender, EventArgs e)
        {
            treev23.Nodes.Remove(treev23.SelectedNode);
        }
    }   
}  

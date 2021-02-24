using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoColaborativo2.Logica;

namespace TrabajoColaborativo2.Presentacion.Controles
{
    public partial class frmCapituloUno : Form
    {
        public frmCapituloUno()
        {
            InitializeComponent();
            grbCalendario.Visible = false;
            grbInformacion.Visible = false;
            grbListaCompra.Visible = false;
        }

        
        //Checkbox ------------------------------------------------------------------------
        private void cbCalendario_CheckedChanged(object sender, EventArgs e)
        {

            if (cbCalendario.Checked)
            {
                grbCalendario.Visible = true;
                
            }
            else
            {
                grbCalendario.Visible = false;
               
            }
        }

        private void cbListaCompra_CheckedChanged(object sender, EventArgs e)
        {
            if (cbListaCompra.Checked)
            { 
                grbListaCompra.Visible = true;
            }
            else
            {  
                grbListaCompra.Visible = false;
            }
           
        }

        private void cbInformacion_CheckedChanged(object sender, EventArgs e)
        {
            if (cbInformacion.Checked)
            {           
                grbInformacion.Visible = true;              
            }
            else
            {              
                grbInformacion.Visible = false;              
            }
          
        }
        //  Lista de alimentos---------------------------------------------------------
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            chlAlimento.Items.Add(txtAgregar.Text);
            MessageBox.Show("Se a añadido un nuevo producto a us lista", "Registrar",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    
        private void chlAlimento_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            int producto = chlAlimento.SelectedIndex;

            if (chlAlimento.GetItemChecked(producto) == false)
            {
                MessageBox.Show("Producto Registrado");
                
            }
        }

        //  Calendario ----------------------------------------------------------------
        private void btnProcesar_Click(object sender, EventArgs e)
        {
            txtFecha.Text = dtpFecha.Value.ToString();
            txtRango.Text = mcCalendarioGrande.SelectionRange.ToString();
            txtFin.Text = mcCalendarioGrande.SelectionRange.Start.ToString();
            txtInicio.Text = mcCalendarioGrande.SelectionRange.End.ToString();
        }
        //LinkLabel--------------------------------------------------------------------

        private void llblUrl1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.youtube.com/?hl=es-419");
            
        }

        private void llblUrl2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://docs.microsoft.com/en-us/dotnet/api/system.web.ui.webcontrols.checkboxlist?view=netframework-4.8");
        }

        private void llblUrl3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://sena.territorio.la/cms/index.php");
        }

        private void llblUrl4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.facebook.com/");
        }
    }
}

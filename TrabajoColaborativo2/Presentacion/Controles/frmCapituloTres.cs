using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoColaborativo2.Presentacion.Controles
{
    public partial class frmCapituloTres : Form
    {
        public frmCapituloTres()
        {
            InitializeComponent();
            grpWebBrowser.Visible = false;
            // grpRadioButton.Visible = false;
            //grpBarra.Visible = false;
            grpAjusteImagen.Visible = false;




        }
        public int contador { get; set; }




        private void frmContoles_Load(object sender, EventArgs e)
        {

        }

        private void pAtras_Click(object sender, EventArgs e)
        {
            Navegador.GoBack();
        }

        private void pIr_Click(object sender, EventArgs e)
        {
            Navegador.Navigate(txtUrl.Text);
            this.barraProgreso.Value = 0;
            contador = 0;
            this.timer1.Start();
        }

        private void pI_Click(object sender, EventArgs e)
        {
            Navegador.GoHome();
        }

        private void pImprimir_Click(object sender, EventArgs e)
        {
            Navegador.ShowPrintDialog();
        }

        private void pPreview_Click(object sender, EventArgs e)
        {
            Navegador.ShowPrintPreviewDialog();
        }

        private void btnWebBrowser_Click(object sender, EventArgs e)
        {
            grpWebBrowser.Visible = true;
            toolTip1.SetToolTip(pAtras, "Atras");
            toolTip1.SetToolTip(pIr, "Ir");
            toolTip1.SetToolTip(pHome, "Inicio");
            toolTip1.SetToolTip(pImprimir, "Imprimir");
            toolTip1.SetToolTip(pPreview, "Preview");
            toolTip1.SetToolTip(pNotaRapida, "Nota Rapida");
            toolTip1.SetToolTip(pAjustes, "Ajuste Imagen");
        }

        private void btnProgressBar_Click(object sender, EventArgs e)
        {
            //grpBarra.Visible = true;
            this.barraProgreso.Value = 0;
            contador = 0;
            lblProgreso.Text = 0 + "%";





        }

        private void btnStart_Click(object sender, EventArgs e)
        {




        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblProgreso.Visible = true;
            this.barraProgreso.Increment(1);

            contador = contador + 1;

            if (contador % 2 == 0)
            {
                lblProgreso.Text = "Progreso.." + " " + contador.ToString() + "%";
            }
            else
            {
                lblProgreso.Text = "Progreso...." + " " + contador.ToString() + "%";

            }


            if (contador == 100)
            {
                this.timer1.Stop();
            }

        }



       

        private void btnRadioButton_Click(object sender, EventArgs e)
        {
            //grpRadioButton.Visible = true;
        }

        private void btnRichTextBox_Click(object sender, EventArgs e)
        {
            frmRichTextBox objRichTextBox = new frmRichTextBox();
            objRichTextBox.Show();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            ActiveForm.Opacity = ((double)(tbOpacidad.Value) / 10.0);
           




        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (rdbColor1.Checked==true)

            {
                
                btnGuardar.BackColor = Color.FromArgb(40, 169, 150);
                btnWebBrowser.BackColor = Color.FromArgb(40, 169, 150);
                pweb.BackColor = Color.FromArgb(40, 169, 150);
                panel1.BackColor = Color.FromArgb(40, 169, 150);


            }
            else if (rdbColor2.Checked==true)
            {
                btnGuardar.BackColor = Color.DodgerBlue;
                btnWebBrowser.BackColor = Color.DodgerBlue;
                pweb.BackColor = Color.DodgerBlue;
                panel1.BackColor = Color.DodgerBlue;
            }
            grpAjusteImagen.Visible = false;
        }

        private void pAjustes_Click(object sender, EventArgs e)
        {
            grpAjusteImagen.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmRichTextBox objTextRich = new frmRichTextBox();
            objTextRich.Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoColaborativo2.Presentacion.Controles
{
    public partial class frmCapituloCuatro : Form
    {
        public frmCapituloCuatro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                rtbTexto.ForeColor = colorDialog1.Color;
            }
        }

        private void btnFuente_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                rtbTexto.Font = fontDialog1.Font;
            }
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Archivos txt (*.txt)|*.txt";
            openFileDialog1.Title = "Abrir";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtAbrir.Text = openFileDialog1.FileName;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Archivos txt (*.txt)| *.txt";
            saveFileDialog1.Title = "Guardar";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtGuardar.Text = saveFileDialog1.FileName;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.Description = "Seleccione la ruta";
            folderBrowserDialog1.RootFolder = Environment.SpecialFolder.Desktop;
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK )
            {
                txtBuscar.Text = folderBrowserDialog1.SelectedPath;
            }
        }
    }
}

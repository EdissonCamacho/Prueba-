using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoColaborativo2.Logica.General;

namespace TrabajoColaborativo2.Presentacion.Conceptos
{
    public partial class frmVideo : Form
    {
        private string ruta = "";
        public frmVideo()
        {
            InitializeComponent();
        }
        private OpenFileDialog objFiltrar;

        
        private void btnCargar_Click(object sender, EventArgs e)
        {
            try
            {       
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    ruta = openFileDialog1.FileName;
                    
                }
                
            }
            catch (Exception) { }

        }

  

        private void btnReproducir_Click_1(object sender, EventArgs e)
        {
            try
            {
                string ruta = @"../../Presentacion/Videos/y2mate.com - ¿Qué es el .NET Framework__v240P";
                axWindowsMediaPlayer1.URL = ruta;
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
            catch (Exception) { }
        }

        private void frmVideo_Load(object sender, EventArgs e)
        {

        }
    }
}

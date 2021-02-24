using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoColaborativo2.Logica.General;

namespace TrabajoColaborativo2.Presentacion.General
{
    public partial class frmImagenes : Form
    {
        public frmImagenes()
        {
            InitializeComponent();
        }
        
        private OpenFileDialog objSeleccionar;
        private void btnSeleccionarImagen_Click(object sender, EventArgs e)
        {
            objSeleccionar = new OpenFileDialog();
            objSeleccionar.Filter = "Imagenes|*.jpg; *.png";
            objSeleccionar.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            objSeleccionar.Title = "Seleccionar imagen";
            if (objSeleccionar.ShowDialog() == DialogResult.OK)
            {
                pbImagen.Image = Image.FromFile(objSeleccionar.FileName);
                txtRuta.Text = objSeleccionar.FileName;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string rutaDos = @"../../Presentacion/Imagenes";
           
            string ruta = Path.Combine(rutaDos," " + objSeleccionar.SafeFileName);
                pbImagen.Image.Save(ruta,ImageFormat.Jpeg);
                txtGuardar.Text = ruta;
            
        }

       
    }
}



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoColaborativo2.Presentacion.General
{
    public partial class frmPDF : Form
    {
        public frmPDF()
        {
            InitializeComponent();
        }

        private void btnPDF1_Click(object sender, EventArgs e)
        {
            string rutaLocal = @"../../Presentacion/General/PDF";
            string ruta = Path.Combine(rutaLocal, "pdf1.pdf");

            if (ckbExterno.Checked == false)
            {
                verPDF.LoadFile(ruta);
            }
            else
            {
                Process p = new Process();
                p.StartInfo.FileName = ruta;
                p.Start();
            }
        }

        private void btnPDF2_Click(object sender, EventArgs e)
        {
            string rutaLocal = @"../../Presentacion/General/PDF";
            string ruta = Path.Combine(rutaLocal, "pdf2.pdf");

            if (ckbExterno.Checked == false)
            {
                verPDF.LoadFile(ruta);
            }
            else
            {
                Process p = new Process();
                p.StartInfo.FileName = ruta;
                p.Start();
            }
        }

        private void btnPDF3_Click(object sender, EventArgs e)
        {
            string rutaLocal = @"../../Presentacion/General/PDF";
            string ruta = Path.Combine(rutaLocal, "pdf3.pdf");

            if (ckbExterno.Checked == false)
            {
                verPDF.LoadFile(ruta);
            }
            else
            {
                Process p = new Process();
                p.StartInfo.FileName = ruta;
                p.Start();
            }
        }
    }
}

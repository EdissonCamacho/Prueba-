using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoColaborativo2.Logica;
using TrabajoColaborativo2.Logica.Archivos;
using TrabajoColaborativo2.Logica.Ejercicios_Estructurados_de_Datos;
using TrabajoColaborativo2.Presentacion.Conceptos;
using TrabajoColaborativo2.Presentacion.Controles;
using TrabajoColaborativo2.Presentacion.Ejercicios_Estructurados_de_Datos;
using TrabajoColaborativo2.Presentacion.Ejercicios_Secuenciales;
using TrabajoColaborativo2.Presentacion.General;
using TrabajoColaborativo2.Presentacion.Archivos_Planos.txt;

namespace TrabajoColaborativo2.Presentacion
{

    public partial class frmInformacion : Form
    {
        public frmInformacion()
        {
            InitializeComponent();
            
        }

        clLogicaArchivos objArchivos = new clLogicaArchivos();

        private void mtdCerrarForms(string formulario = "")
        {
            FormCollection formulariosApp = Application.OpenForms;
            /*foreach (Form f in formulariosApp)
            {
                var nombre = f.Name;
                if (f.Name != "frmInformacion" && f.Name != formulario)
                {
                    f.Hide();
                }
            }*/
            for(int i = 0; i < formulariosApp.Count; i++)
            {
                var nombre = formulariosApp[i].Name;
                if (nombre != "frmInformacion" && nombre != formulario)
                {
                    formulariosApp[i].Hide();
                }
            }
        }


        private void informaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {

            objArchivos.mtdIntegrantes();
          
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            objArchivos.mtdSalir();
        }

        private void secuencialesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSecuenciales objSecuenciales = new frmSecuenciales();
            objSecuenciales.MdiParent = this;
            mtdCerrarForms("frmSecuenciales");
            objSecuenciales.Show();
            

        }

        private void condicionalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCondicionales objCondicionales = new frmCondicionales();
            objCondicionales.MdiParent = this;
            mtdCerrarForms("frmCondicionales");
            objCondicionales.Show();
            
        }

        private void ciclosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCiclos objCiclos = new frmCiclos();
            objCiclos.MdiParent = this;
            mtdCerrarForms("frmCiclos");
            objCiclos.Show();



        }

        private void vectoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVectores objVectores = new frmVectores();
            objVectores.MdiParent = this;
            mtdCerrarForms("frmVectores");
            objVectores.Show();
            
                


        }

        private void listasListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListas objListas = new frmListas();
            objListas.MdiParent = this;
            mtdCerrarForms("frmListas");
            objListas.Show();
        }

        private void documentoPDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPDF objPdf = new frmPDF();
            objPdf.MdiParent = this;
            mtdCerrarForms("frmPdf");
            objPdf.Show();
        }

        private void envioCorreoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEnvioCorreo objEnvio = new frmEnvioCorreo();
            objEnvio.MdiParent = this;
            mtdCerrarForms("frmEnvioCorreo");
            objEnvio.Show();
        }

        private void imagenesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmImagenes objImagenes = new frmImagenes();
            objImagenes.MdiParent = this;
            mtdCerrarForms("frmImagenes");
            objImagenes.Show();
        }

        private void capitulo1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCapituloUno objControUno = new frmCapituloUno();
            objControUno.MdiParent = this;
            mtdCerrarForms("frmCapituloUno");
            objControUno.Show();
        }

        private void capitulo2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCapitulodos objControldos = new frmCapitulodos();
            objControldos.MdiParent = this;
            mtdCerrarForms("frmCapitulodos");
            objControldos.Show();
        }

        private void capitulo3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCapituloTres objControltres = new frmCapituloTres();
            objControltres.MdiParent = this;
            mtdCerrarForms("frmCapituloTres");
            objControltres.Show();



        }

        private void capitulo4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCapituloCuatro objControlesCuarto = new frmCapituloCuatro();
            objControlesCuarto.MdiParent = this;
            mtdCerrarForms("frmCapituloCuatro");
            objControlesCuarto.Show();
        }

        private void visualStudionetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVisualstudio objVisual = new frmVisualstudio();
            objVisual.MdiParent = this;
            mtdCerrarForms("frmVisualStudio");
            objVisual.Show();

        }

        private void tiposDeDatosCnetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTiposDatos objTiposDatos = new frmTiposDatos();
            objTiposDatos.MdiParent = this;
            mtdCerrarForms("frmTiposDatos");
            objTiposDatos.Show();

        }

        private void frameworknetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVideo objVideo = new frmVideo();
            objVideo.MdiParent = this;
            mtdCerrarForms("frmVideo");
            objVideo.Show();

        }

        private void registrarDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTXT objResgistrar = new frmTXT();
            objResgistrar.MdiParent = this;
            mtdCerrarForms("frmTXT");
            objResgistrar.Show();

        }

        private void verDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVerDatosTXT objVerdatos = new frmVerDatosTXT();
            objVerdatos.MdiParent = this;
            mtdCerrarForms("frmVerDatosTXT");
            objVerdatos.Show();
        }

        private void frmInformacion_Load(object sender, EventArgs e)
        {
            menuStrip1.ForeColor = Color.White;
            this.BackColor = Color.White;
        }

       
    }
}

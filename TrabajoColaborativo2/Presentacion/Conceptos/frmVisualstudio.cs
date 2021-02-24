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
    public partial class frmVisualstudio : Form
    {
        public frmVisualstudio()
        {
            InitializeComponent();
        }

        private void frmVisualstudio_Load(object sender, EventArgs e)
        {
            /*lblDef.Text = ("es un panel de inicio creativo que se puede usar para editar, depurar y compilar código y, después, publicar una aplicación. \n" +
                "Un entorno de desarrollo integrado (IDE) es un programa con numerosas características que se pueden usar para muchos aspectos del desarrollo de software. \n");*/
        }

        private void btnVisual_Click(object sender, EventArgs e)
        {
            rctdefi.Text = ("Es un panel de inicio creativo que se puede usar para editar, depurar y compilar código y, después, publicar una aplicación. \n" +
                "Un entorno de desarrollo integrado (IDE) es un programa con numerosas características que se pueden usar para muchos aspectos del desarrollo de software. \n" +
                "\n" + "  Caracteristicas:  ." + "\n" + " * Instalación modular " + "\n" + " * Creación de aplicaciones para la nube para Azure." + "\n" + " * Creación de aplicaciones para la Web." + "\n" + " * Compilar aplicaciones y juegos multiplataforma." + "\n"
                + "\n" + "  * Conectarse a bases de datos." + "\n" + " * Depure, pruebe y mejore su código." + "\n" + " * Depure, pruebe y mejore su código." + "\n" + " * Implementar la aplicación finalizada." + "\n" +
                "\n" + "Visual Studio 2019 tendrá 3 versiones, las cuales son: Community, Professional y Enterprise" + "\n");


        }
    }
}

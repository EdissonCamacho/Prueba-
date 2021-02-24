using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoColaborativo2.Logica.Archivos
{
    class clLogicaArchivos
    {
        public void mtdSalir ()
        {

            Application.Exit();
        }
       public void mtdIntegrantes ()
        {
            MessageBox.Show("Lista Integrantes:\n" +
                            "Edisson Armando Camacho Camargo\n" +
                            "German Andres Montañez Hermida\n" +
                            "Rafael Antonio Gavidia Montaña\n" +
                            "Danna Gabriela Camargo Siabato\n" +
                            "\n","Acerca De:",MessageBoxButtons.OK,MessageBoxIcon.Question);
        }

 
    
    }
}    


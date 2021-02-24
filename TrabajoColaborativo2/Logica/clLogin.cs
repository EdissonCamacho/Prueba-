using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoColaborativo2.Presentacion;

namespace TrabajoColaborativo2.Logica
{
    class clLogin 
    {
        public string usuario { get; set; }
        public string contraseña { get; set; }

        private int intentos = 0;
        public string mensaje { get; set; }
       
       

        public Boolean mtdLogin()
        {
            Boolean estado = false;
            if (intentos < 3)
            {
                if ((usuario == "Administrador" && contraseña == "admin") ||
                    (usuario == "Instructor" && contraseña == "987") ||
                    (usuario == "" && contraseña == ""))
                {

                    estado = true;
       
                }
                else
                {
                    intentos++;
                    MessageBox.Show("Contraseña y Usuario no Valido","Error de Inicio",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }else
            {
                // MessageBox.Show("No quedan mas intentos");
                mensaje = "No quedan mas intentos";
                
                
            }
            return estado;
        }
    }
}

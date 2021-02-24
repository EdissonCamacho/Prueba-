using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace TrabajoColaborativo2.Logica.Archivos_Planos.txt
{
    class clLogicaRegistrar
    {
        public string documento { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public string fecha { get; set; }
        public string genero { get; set; }
        public string email { get; set; }
        public long celular { get; set; }

        private string ruta = @"../../Datos/Datos.txt";

        public void mtdRegistrarDatos()
        {
            StreamWriter txt = new StreamWriter(ruta, true, Encoding.UTF8);
            txt.WriteLine("------------------------------------------------------------");
            txt.WriteLine("Documento: "+documento+" / Nombres: "+nombres);
            txt.WriteLine("Apellidos: "+apellidos+" / Fecha nacimiento: "+fecha);
            txt.WriteLine("Genero: "+genero+" / Email: "+email+" / Celular: "+celular);
            txt.Close();
            MessageBox.Show("Datos registrados correctamente");
        }

        public string mtdMostrarDatos()
        {
            string mostrarDatos = "";
            StreamReader txt = new StreamReader(ruta);

            string linea = txt.ReadLine();

            while (linea != null)
            {
                mostrarDatos = mostrarDatos + linea + "\n";
                linea = txt.ReadLine();
            }
            txt.Close();
            return mostrarDatos;
        }
    }
}

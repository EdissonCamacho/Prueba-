using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoColaborativo2.Logica.Ejercicios_Estructurados_de_Datos
{
    class clListas : IComparable<clListas>
    {
        public double doc { get; set; }
        public string nombre { get; set; }
        public string apelllidos { get; set; }
        public int edad { get; set; }
        public string Genero { get; set; }
        public string Nacionalidad { get; set; }
        public string telefono { get; set; }
        public clListas datos { get; set; }
        public string dbnombre { get; set; }//Dato a buscar
        public double dbdoc { get; set; }//Dato a Buscar
        public string dbnacionalidad { get; set; }//Dato a Buscar
        List<clListas> listaAprendizes = new List<clListas>();
        public int CompareTo(clListas other)
        {
            if (this.doc >other.doc)
            {
                return 1;
            }
            else if (this.doc < other.doc)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }


        public void mtdRegistar()
        {
            clListas objDatos = new clListas();
            objDatos.doc = doc;
            objDatos.nombre = nombre;
            objDatos.apelllidos = apelllidos;
            objDatos.edad = edad;
            objDatos.Genero = Genero;
            objDatos.Nacionalidad = Nacionalidad;
            objDatos.telefono = telefono;
            listaAprendizes.Add(objDatos);


            

        }
        public List<clListas> mtdVisualizar()
        {
            return listaAprendizes;
        }
        public List<clListas> mtdOrdenar()
        {
            listaAprendizes.Sort();
            return listaAprendizes;
        }
        public List<clListas> mtdBuscar()
        {
            return listaAprendizes;


        }
        
    }
}

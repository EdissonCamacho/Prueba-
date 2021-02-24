using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoColaborativo2.Logica.Ejercicios_Estructurados_de_Datos
{
    class clLogicaVectores
    {
        private int[] documento;
        private string[] nombres;
        private int contadorVector;

        public void mtdNuevoVector(int tamaño)
        {
            documento = new int[tamaño];
            nombres = new string[tamaño];
            contadorVector = 0;
            MessageBox.Show("Nuevo vector creado correctamente");
        }

        public void mtdCargarVector(int documento, string nombres)
        {
            if (contadorVector < this.documento.Length)
            {
                this.documento[contadorVector] = documento;
                this.nombres[contadorVector] = nombres;
                contadorVector++;
                MessageBox.Show("Registro N_"+contadorVector+" registrado correctamente");
            }
            else
            {
                MessageBox.Show("Vector lleno");
            }
        }

        public string mtdMostrarVector()
        {
            string datosVector = "";
            for(int i=0; i<documento.Length; i++)
            {
                datosVector = datosVector+"Documento: "+documento[i]+" Nombres: "+nombres[i]+ "\n";
            }
            return datosVector;
        }

        public void mtdOrdenarVector()
        {
            Array.Sort(documento);
            Array.Sort(nombres);
        }

        public string mtdBuscarVector(int index, string dato)
        {
            string datosVector = "";
            if (index == 0)
            {
                int documentoBuscar = int.Parse(dato);
                for (int i = 0; i < documento.Length; i++)
                {
                    if (documento[i] == documentoBuscar)
                    {
                        datosVector = datosVector + "Documento: " + documento[i] + " Nombres: " + nombres[i] + "\n";
                    }
                }
            }
            else
            {
                for (int i = 0; i < documento.Length; i++)
                {
                    if (nombres[i].Contains(dato))
                    {
                        datosVector = datosVector + "Documento: " + documento[i] + " Nombres: " + nombres[i] + "\n";
                    }
                }
            }
            if (datosVector == "") { MessageBox.Show("Dato no encontrado"); }
            return datosVector;
        }
    }
}

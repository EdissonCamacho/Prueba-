using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoColaborativo2.Logica.Ejercios_Algoritmos
{
    class clCondicionales
    {
        public int edad { get; set; }
        public int nivelEducativo { get; set; }
        public double puntajeEntrevista { get; set; }

        public void mtdComprobarAprobacion()
        {
            if(edad > 16 && nivelEducativo == 0 && puntajeEntrevista >= 85)
            {
                MessageBox.Show("El aspirante fue aprobado.");
            }
            else
            {
                MessageBox.Show("El aspirante no aprobado.");
            }
        }
        public int horasTrabajadas { get; set; }
        public double  valorApagar { get; set; }

        public void mtdHorasapagar()
        {
            double resultadoH = 0;
           
            resultadoH = 30 * 26000;//30horas *26000
            if (horasTrabajadas<=30)
            {
                valorApagar = resultadoH;

            }
            else if (horasTrabajadas>30)
            {
                valorApagar = horasTrabajadas * 26000;//40 *26000
                double horasExtras =( (valorApagar - resultadoH)/26000)*30000;
                valorApagar = resultadoH + horasExtras;
            }
        } 

    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoColaborativo2.Logica.Ejercios_Algoritmos
{
    class clSecuenciales
    {
        public double notasParciales { get; set; }
        public double notaP { get; set; }
        public double notaE { get; set; }
        private double acumuladorParciales=0;//Acumula las notas parciales
        public double total { get; set; }

        public void mtdAgregarNota()
        {
            acumuladorParciales = acumuladorParciales + notasParciales;
        }
        public void mtdCalcular()
        {
            double promedionotas1 = (acumuladorParciales / 4) * 0.55;// Notas parciales 
            double promedionotas2 = notaP * 0.30;//notas Proyecto
            double promedionotas3 = notaE * 0.15;//nota Exposicion

             total = promedionotas1 + promedionotas2 + promedionotas3;//nota final

        }public void mtdLimpiar()
        {
            notaE = 0;
            notaP = 0;
            acumuladorParciales = 0;
            total = 0;
            notasParciales = 0;
        }

        public double Urgencias { get; set; }
        public double Pediatria { get; set; }
        public double Traumatologia { get; set; }
        public double ValorMonetario { get; set; }



        public void mtdPresupuesto()
        {

            Urgencias = ValorMonetario * 0.37;
            Pediatria = ValorMonetario * 0.42;
            Traumatologia = ValorMonetario * 0.21;
            




        }
    }
}

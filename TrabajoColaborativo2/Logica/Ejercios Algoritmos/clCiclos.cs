using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoColaborativo2.Logica.Ejercios_Algoritmos
{
    class clCiclos
    {
        public int Numero { get; set; }

        public int SumaTotal { get; set; }



        public void mtdSumando()
        {
            SumaTotal = 0;
            for (int i = 1; i <= Numero; i++)
            {
                SumaTotal = SumaTotal + i;

            }

        }
        public double Tnumero { get; set; }
        public double Total { get; set; }
        public void mtdResultado()
        {
            /* // Total = 1;
              for (int i = 1; i <= Tnumero; i++)
              {

                  Total = (Total+ 1)/i;
              }*/

            for (int i = 20; i >= -10; i--)


            {
                if (i != 0)
                {
                    MessageBox.Show("y=1+1/" + i + "=" + 2 / i);

                }
                else
                {
                    MessageBox.Show("y=1+1/" + i + "=" + 0);
                }

            }

        }

        
        public int Numero3 { get; set; }
        public int limite { get; set; }
        public int Resultado4 { get; set; }


        public void mtdResultadoop()
        {
            
            
            for (int i = 0; i <= limite; i++)
            {
                Resultado4 = Numero3 * i;
                
              MessageBox.Show(Numero3 + "x" + i + "=" + Resultado4);

            }

        }



    } 
}
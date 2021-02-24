using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoColaborativo2.Presentacion.Conceptos
{
    public partial class frmTiposDatos : Form
    {
        public frmTiposDatos()
        {
            InitializeComponent();
        }

        private void frmTiposDatos_Load(object sender, EventArgs e)
        {
            lblExplicacion.Text = "Un tipo de datos es la propiedad de un valor que determina su dominio (qué valores puede tomar), qué operaciones se le pueden aplicar y \n" +
                "cómo es representado internamente por el computador.";
            this.tbdatatype.Rows.Add("Byte", "1 byte", "0 a 255");
            this.tbdatatype.Rows.Add("Char", "2 byte", "U+0000 a U+ffff (caractreres Unicode)");
            this.tbdatatype.Rows.Add("Short", "2 bytes", "-32,768 a 32,767");
            this.tbdatatype.Rows.Add("Int", "4 bytes", "-2,147,483,648 a 2,147,483,647");
            this.tbdatatype.Rows.Add("Long", "8 bytes", "-9,223,372,036,854,775,808 a 9,223,372,036,854,775,807");
            this.tbdatatype.Rows.Add("Float", "4 bytes", "± 1.5e-45 a ±3.4e38");
            this.tbdatatype.Rows.Add("Double", "8 byteS", "±5.0e-324 a ±1.7e308");
            this.tbdatatype.Rows.Add("Bool", "2 bytes", "Verdadero o Falso");
            this.tbdatatype.Rows.Add("String", "-", "Cero o más caracteres Unicodes");
            tbdatatype.BackgroundColor = Color.DodgerBlue;
            tbdatatype.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbdatatype.Visible = true;
        }
    }
}

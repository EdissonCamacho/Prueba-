using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoColaborativo2.Logica.Ejercicios_Estructurados_de_Datos
{
    public partial class frmListas : Form
    {
        public frmListas()
        {
            InitializeComponent();
            grpRegistar.Visible = false;
            grpVisualizar.Visible = false;
            grpOrdenar.Visible = false;
            grpBuscar.Visible = false;

            cmdNacionalidad.Items.Add("Colombiana");//Nacionalidad
            cmdNacionalidad.Items.Add("Venezolana");//Nacionalidad
            cmdBuscar.Items.Add("Nombre");
            cmdBuscar.Items.Add("Documento");
            cmdBuscar.Items.Add("Nacionalidad");
            


        }
        clListas objListas = new clListas();
        private void button1_Click(object sender, EventArgs e)
        {
            grpRegistar.Visible = true;

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            objListas.doc = double.Parse(txtdoc.Text);
            objListas.nombre = txtNombre.Text;
            objListas.apelllidos = txtApellidos.Text;
            objListas.edad = int.Parse(txtEdad.Text);
            if (rbdM.Checked==true)
            {
                objListas.Genero = "Masculino";


            }
            else if (rbdF.Checked==true)
            {
                objListas.Genero = "Femenino";
            }
            objListas.Nacionalidad = cmdNacionalidad.Text;
            objListas.telefono = txtTelefono.Text;
            objListas.mtdRegistar();
            txtdoc.Clear();
            txtNombre.Clear();
            txtApellidos.Clear();
            txtEdad.Clear();
            txtTelefono.Clear();
            



            
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            grpVisualizar.Visible = true;
            List<clListas> listaVisualizar = new List<clListas>();
            listaVisualizar = objListas.mtdVisualizar();
            lbxDatos.Items.Clear();
            foreach (var item in listaVisualizar)
            {
                lbxDatos.Items.Add(item.doc+" "+item.nombre + " " + item.apelllidos + " " + item.edad + " " +
                    item.Genero + " " + item.Nacionalidad + " " + item.telefono);
            }

        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            
            grpOrdenar.Visible = true;
            List<clListas> listaOrdenar = new List<clListas>();
            listaOrdenar = objListas.mtdOrdenar();
            lbxOrdenar.Items.Clear();
            

            foreach (var item in listaOrdenar)
            {
                lbxOrdenar.Items.Add(item.doc + " " + item.nombre + " " + item.apelllidos + " " + item.edad + " " +
                    item.Genero + " " + item.Nacionalidad + " " + item.telefono);
            }
            
            
            /*  //iLista = miLista.OrderBy(x => x.Fecha);
               lbxOrdenar.Items.Clear();
               IEnumerable<clListas> listaordenada = listaOrdenar.OrderBy(n => n.nombre);
               foreach (var item in listaOrdenar)
               {
                   lbxOrdenar.Items.Add (
               }*/
          //  Array.Sort(Vector);
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            grpBuscar.Visible = true;
        }

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            
            
            List<clListas> listaBuscar = new List<clListas>();

            listaBuscar=  objListas.mtdBuscar();
            lbxBuscar.Items.Clear();



            foreach (var item in listaBuscar)
            {
                if (txtDatoBuscar.Text!=null)
                {
                    if (cmdBuscar.Text == "Documento" && item.doc == double.Parse(txtDatoBuscar.Text))
                    {
                        lbxBuscar.Items.Add(item.doc + " " + item.nombre + " " + item.apelllidos + " " + item.edad + " " +
                    item.Genero + " " + item.Nacionalidad + " " + item.telefono);
                    }
                    else if (cmdBuscar.Text == "Nombre" && item.nombre == txtDatoBuscar.Text)
                    {
                        lbxBuscar.Items.Add(item.doc + " " + item.nombre + " " + item.apelllidos + " " + item.edad + " " +
                    item.Genero + " " + item.Nacionalidad + " " + item.telefono);
                    }
                    else if (cmdBuscar.Text == "Nacionalidad" && item.Nacionalidad == txtDatoBuscar.Text)
                    {
                        lbxBuscar.Items.Add(item.doc + " " + item.nombre + " " + item.apelllidos + " " + item.edad + " " +
                    item.Genero + " " + item.Nacionalidad + " " + item.telefono);
                    }
                }
            }

            

           
        }
    }
}

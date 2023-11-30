using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaInterfaces
{
    public partial class FrmPrestamos : Form
    {

        public FrmPrestamos()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
            AnadirLibros(FrmPadre.ListaLibro);
        }
        private void FrmPrestamos_Load(object sender, EventArgs e)
        {
            AnadirUsuarios(FrmPadre.ListaUsuario);

        }
        private void AnadirLibros(List<Libro> listaLibro)
        {
            
            foreach (Libro l in listaLibro)
            {
                listBoxLibros.Items.Add(l.Titulo.Replace(',', ' ').Trim() + " - " + l.ID);

                
            }
        }

        private void AnadirUsuarios(List<Persona> listaUsuario)
        {
            foreach (Persona p in listaUsuario)
            {
                DateTime date = DateTime.Today;
                if (p.FechaSancion != null)// || p.FechaSancion == "  /  /  ")
                {

                    String[] fecha = p.FechaSancion.Trim().Split('/');

                    if (!fecha[0].Equals(String.Empty) && !fecha[1].Equals(String.Empty) && !fecha[2].Equals(String.Empty))
                        if (fecha.Length >= 3) //Comprobar que la sanción no es vigente
                        {
                            int day = Convert.ToInt32(fecha[0]);
                            int month = Convert.ToInt32(fecha[1]);
                            int year = Convert.ToInt32(fecha[2]);
                            date = new DateTime(year, month, day);
                            
                        }
                }

                if (DateTime.Compare(date, DateTime.Today) <= 0) //d1 es anterior a d2
                {
                    listBoxUsuarios.Items.Add(p.Nombre);
                }
            }
        }

        private void BtnAnadirUsuario_Click(object sender, EventArgs e)
        {
            if (listBoxUsuarios.SelectedItem != null && listBoxLibros.SelectedItem != null)
            {
                //prestamo Juan Dorado, 4444, #01/03/2022#
                Persona p = null;
                Libro l = null;
                String[] infoLibro = listBoxLibros.SelectedItem.ToString().Split('-');
                string idLibro = infoLibro[infoLibro.Length - 1].Trim();
                //Buscamos la persona con ese nombre y el libro por el id
                foreach (Persona per in FrmPadre.ListaUsuario)
                {
                    if (per.Nombre.ToLower().Equals(listBoxUsuarios.SelectedItem.ToString().ToLower()))
                    {
                        p = per;
                    }
                }
                foreach (Libro lbr in FrmPadre.ListaLibro)
                {
                    if (lbr.ID == int.Parse(idLibro))
                    {
                        l = lbr;
                    }
                }

                
                string fechaDevoluccion;// = p.CalcularFechaDevolucion(l).ToShortDateString();
                if (p.GetType().Equals(typeof(Alumno)))
                {
                    Alumno aux = (Alumno)p;
                    fechaDevoluccion = aux.CalcularFechaDevolucion(l).ToShortDateString();
                }
                else if (p.GetType().Equals(typeof(Profesor)))
                {
                    Profesor aux = (Profesor)p;
                    fechaDevoluccion = aux.CalcularFechaDevolucion(l).ToShortDateString();
                }
                else
                {
                    Pas aux = (Pas)p;
                    fechaDevoluccion = aux.CalcularFechaDevolucion(l).ToShortDateString();
                }

                




               
               

                String transaccion = "prestamo " + p.Nombre + ", " + l.ID + ", #" + fechaDevoluccion + "#";

                FrmPadre.ListaTransaccion.Add(new Transaccion("prestamo", l, p, fechaDevoluccion));
                Transaccion.EscribirTransaccion(transaccion,this);
            }
            else
            {
                MessageBox.Show("Seleccione una opción");
            }


        }

        
    }
}

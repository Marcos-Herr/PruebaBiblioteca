using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaInterfaces
{
    public partial class FrmDevolucion : Form
    {
        Persona usuario;

        public FrmDevolucion()
        {
            InitializeComponent();

            CargarUsuarios(FrmPadre.ListaTransaccion);
        }

        private void CargarUsuarios(List<Transaccion> listaTransaccion)
        {
            foreach (Transaccion t in listaTransaccion)
            {
                if (t.Tipo.Equals("prestamo"))
                    if (!LstBxUsuarios.Items.Contains(t.Usuario.Nombre))
                    {
                        LstBxUsuarios.Items.Add(t.Usuario.Nombre);

                    }
            }
        }

        private void LstBxUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            LstBxLibros.Items.Clear();
            usuario = null;
            foreach (Persona p in FrmPadre.ListaUsuario)
            {
                if (p.Nombre.Equals(LstBxUsuarios.SelectedItem.ToString())) usuario = p;
            }

            foreach (Transaccion t in FrmPadre.ListaTransaccion)
            {
                if (t.Tipo.Equals("prestamo"))
                    if (t.Usuario.Nombre.Equals(usuario.Nombre) && !LstBxLibros.Items.Contains(t.Libro.Titulo))
                    {
                        LstBxLibros.Items.Add(t.Libro.Titulo);

                    }
            }
        }

        private void BtnDevolver_Click(object sender, EventArgs e)
        {
            Libro libro = null;
            if (LstBxLibros.SelectedItem != null && LstBxUsuarios.SelectedItem != null)
            {
                foreach (Libro l in FrmPadre.ListaLibro)
                {
                    if (l.Titulo.Equals(LstBxLibros.SelectedItem.ToString()))
                    {
                        libro = l;
                    }
                }
                FrmPadre.ListaTransaccion.Add(new Transaccion("devolucion", libro));
                Transaccion tr = null;
                foreach (Transaccion t in FrmPadre.ListaTransaccion)
                {
                    if (t.Tipo.Equals("prestamo"))
                        if (t.Usuario.Nombre.Equals(usuario.Nombre) && t.Libro.Titulo.Equals(libro.Titulo))
                        {
                            tr = t;
                        }
                }
                FrmPadre.ListaTransaccion.Remove(tr);
                

                Transaccion.EscribirTransaccion("devolucion " + libro.ID, this);


            }
            else
            {
                MessageBox.Show("Selecione un libro y un usuario para realizar la devolucion", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

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
    public partial class FrmLibro : Form
    {
        bool esNuevo = false;
        int indice;
        FrmPadre frmPadre;

        public FrmLibro(int i, FrmPadre frm)
        {
            InitializeComponent();
            indice = i;
            frmPadre = frm;
            if (indice != -1)
            {
                TxtBxID.Text = FrmPadre.ListaLibro[indice].ID.ToString();
                TxtBxTitulo.Text = FrmPadre.ListaLibro[indice].Titulo;
                CmbBxUbicacion.SelectedIndex = (FrmPadre.ListaLibro[indice].Ubicacion.ToLower() == "sala" ? 0 : 1);
                BtnGuardar.Text = "Guardar";
                esNuevo = false;
            }
            else
            {
                esNuevo = true;
                BtnGuardar.Text = "Añadir";
                CmbBxUbicacion.SelectedIndex = 0;

            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtBxID.Text.Equals(String.Empty) || TxtBxTitulo.Text.Equals(String.Empty))
                {
                    MensajeError("Los campos no pueden estar vacios");
                }
                else if (IDUsado(int.Parse(TxtBxID.Text), indice))
                {
                    MensajeError("Ya hay un libro con ese codigo");
                }
                else
                {

                    if (esNuevo)
                    {
                        Libro l = new Libro(
                            int.Parse(TxtBxID.Text),
                            TxtBxTitulo.Text,
                            (CmbBxUbicacion.SelectedIndex == 0 ? Libro.Ubicaciones.Sala : Libro.Ubicaciones.Almacen)
                            );
                        FrmPadre.ListaLibro.Add(l);
                        DialogResult dialogResult = MessageBox.Show("Libro agregado con exito");
                        if (dialogResult == DialogResult.OK)
                        {
                            frmPadre.MostrarLibros();
                            this.Close();
                        }

                    }
                    else
                    {
                        Libro l = FrmPadre.ListaLibro[indice];

                        l.ID = int.Parse(TxtBxID.Text);
                        l.setUbicacion((CmbBxUbicacion.SelectedIndex == 0 ? Libro.Ubicaciones.Sala : Libro.Ubicaciones.Almacen));
                        l.Titulo = TxtBxTitulo.Text;
                        DialogResult dialogResult = MessageBox.Show("Libro guardado con exito");
                        if (dialogResult == DialogResult.OK)
                        {
                            frmPadre.MostrarLibros();
                            this.Close();
                        }
                    }
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("El ID solo puede contener numeros", "ERROR ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool IDUsado(int id, int index)
        {
            int contador = 0;
            foreach (Libro l in FrmPadre.ListaLibro)
            {
                if (l.ID == id && contador != index)
                {

                    return true;
                }
                contador++;
            }
            return false;
        }
        private void MensajeError(String s)
        {
            MessageBox.Show(s, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
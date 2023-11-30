using System;
using System.Windows.Forms;

namespace BibliotecaInterfaces
{
    public partial class FrmUsuario : Form
    {
        private int pos = 0;
        private string nombreEdit = "";

        //Constructor para añadir usuarios
        public FrmUsuario()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
            btnAceptar.Text = "AÑADIR";
            lbTop.Text = "NUEVO USUARIO";
            lbFecha.Visible = false;
            mskFecha.Visible = false;
            btnAceptar.Tag = "add";
            cmbTipo.SelectedIndex = cmbTipo.Items.Count - 1;
        }

        //Constructor para editar usuarios
        public FrmUsuario(ListViewItem lvItem, int index)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
            btnAceptar.Text = "MODIFICAR";
            lbTop.Text = "EDITAR USUARIO";
            btnAceptar.Tag = "mod";

            txtNombre.Text = nombreEdit = lvItem.SubItems[1].Text;
            pos = lvItem.Index;
            txtDpt.Text = lvItem.SubItems[2].Text;
            switch (lvItem.SubItems[0].Text.ToLower())
            {
                case "profesor":
                    cmbTipo.SelectedIndex = 0;
                    break;
                case "alumno":
                    cmbTipo.SelectedIndex = 1;
                    break;
                case "pas":
                    cmbTipo.SelectedIndex = 2;
                    break;
                default:
                    cmbTipo.SelectedIndex = 3;
                    break;
            }

            mskFecha.Text = lvItem.SubItems[3].Text;
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            Persona p = new Persona
            {
                Tipo = cmbTipo.SelectedItem.ToString(),
                Nombre = txtNombre.Text,
                Departamento = txtDpt.Text,
                FechaSancion = null                
            };
            

            switch (btnAceptar.Tag)
            {
                case "add":
                    if (ComprobarCampos() && !ExistePersona(txtNombre.Text))
                    {
                        FrmPadre.ListaUsuario.Add(p);
                        MessageBox.Show("Usuario añdido", "Añadir", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    break;
                case "mod":
                    p.FechaSancion = "";
                    if (ComprobarCampos() && comprobarFecha(mskFecha.Text))
                    {
                        if (nombreEdit.Trim().ToLower().Equals(txtNombre.Text.Trim().ToLower()))
                        {
                            p.FechaSancion = mskFecha.Text;
                            FrmPadre.ListaUsuario[pos] = p; //Sustituimos con la nueva persona 
                            MessageBox.Show("Usuario editado", "Editado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            if (!ExistePersona(txtNombre.Text))
                            {
                                FrmPadre.ListaUsuario[pos] = p; //Sustituimos con la nueva persona 
                                MessageBox.Show("Usuario editado", "Editado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Ese nombre ya existe en la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    this.Close();
                    break;
                default:
                    break;
            }
        }

        private bool ExistePersona(String nuevoNombre)
        {
            bool existeP = false;

            foreach (Persona p in FrmPadre.ListaUsuario)
            {
                if (p.Nombre.ToLower().Trim().Equals(nuevoNombre.ToLower().Trim()))
                {
                    existeP = true;
                    MessageBox.Show("Este usuario ya existe en la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return existeP;
        }

        private bool ComprobarCampos()
        {
            bool esCorrecto = true;
            //Nombre solo contiene letras
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtNombre.Text, "^[a-zA-Z ]"))
            {
                MessageBox.Show("El nombre no es correcto");
                esCorrecto = false;
            }
            if (cmbTipo.SelectedIndex == cmbTipo.Items.Count - 1)
            {
                MessageBox.Show("Tienes que seleccionar un tipo de usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                esCorrecto = false;
            }
            /*if (txtNombre.TextLength <= 0 || txtNombre.Text.Trim() == "")
            {
                esCorrecto = false;
                MessageBox.Show("El nombre no puede estar vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
            return esCorrecto;
        }

        private bool comprobarFecha(String fecha)
        {
            try
            {
                DateTime.Parse(fecha);

                return true;
            }
            catch
            {
                if (!mskFecha.MaskCompleted)
                {
                    return true;
                }
                MessageBox.Show("No es una fecha válida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

      
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace BibliotecaInterfaces
{
    public partial class FrmPadre : Form
    {
        private const int TODOS = 0;
        //MOVIMIENTOS
        private const int PRESTAMO = 1;
        private const int DEVOLUCION = 2;
        //OPCIONES DE BUSQUEDA
        private const int TITULO_LIBRO = 0;
        private const int USUARIO = 1;
        private const int DEPARTAMENTO = 2;
        private const int FECHA = 3;

        private string rutaFicheroUsuarios = Environment.CurrentDirectory + @"\usuarios.txt";
        private string rutaFicheroLibros = Environment.CurrentDirectory + @"\libros.txt";
        private string rutaFicheroTransacciones = Environment.CurrentDirectory + @"\transacciones.txt";

        internal static List<Persona> ListaUsuario = new List<Persona>();
        internal static List<Libro> ListaLibro = new List<Libro>();
        internal static List<Transaccion> ListaTransaccion = new List<Transaccion>();

        public FrmPadre()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OrganizarListView();
            OrganizarListView(LvLibro);
            OrganizarListView(lvUsuarios);
            OrganizarListView(lvMovimientos);

            //CARGAR USUARIOS
            CargarUsuarios(rutaFicheroUsuarios);
            MostrarUsuarios();
            //CARGAR LIBROS
            CargarLibros(rutaFicheroLibros);
            MostrarLibros();
            //CARGAR TRANSACCIONES
            CargarTransacciones(rutaFicheroTransacciones);
            boxOpcMovimientos.SelectedIndex = 0;
            calendar.Hide();
            boxOpcBusqueda.SelectedIndex = 0;
            MostrarMovimiento();
        }

        private void OrganizarListView()
        {
            foreach (ColumnHeader column in lvUsuarios.Columns)
            {
                column.Width = lvUsuarios.Width / lvUsuarios.Columns.Count;
            }
        }

        private void OrganizarListView(ListView lv)
        {
            foreach (ColumnHeader column in lv.Columns)
            {
                column.Width = lv.Width / lv.Columns.Count;
            }
        }

        private void CargarUsuarios(string ruta)
        {
            foreach (string line in System.IO.File.ReadLines(ruta))
            {
                String[] datos = line.Split(',');
                String tipo = line.Substring(0, line.IndexOf(" ")).Trim();
                String nombre = datos[0].Substring(datos[0].IndexOf(" ")).Trim();
                String dept = datos[1].Trim().Trim();
                String fecha = null;
                if (datos.Length >= 3)
                {
                    fecha = datos[2].Replace("#", "").Trim();
                }
                
                switch (tipo.Trim())
                {
                    case "profesor":
                        Profesor p = new Profesor
                        {
                            Tipo = tipo,
                            Nombre = nombre,
                            Departamento = dept,
                            FechaSancion = fecha
                        };
                        ListaUsuario.Add(p);
                        break;
                    case "alumno":
                        Alumno a = new Alumno
                        {
                            Tipo = tipo,
                            Nombre = nombre,
                            Departamento = dept,
                            FechaSancion = fecha
                        };
                        ListaUsuario.Add(a);
                        break;
                    case "pas":
                        Pas pas = new Pas
                        {
                            Tipo = tipo,
                            Nombre = nombre,
                            Departamento = dept,
                            FechaSancion = fecha
                        };
                        ListaUsuario.Add(pas);
                        break;
                }
            }
        }

        private void CargarLibros(string rutaFichero)
        {
            string[] lines = File.ReadAllLines(rutaFichero);
            string ubicacion;
            string titulo;
            int id;

            foreach (String s in lines)
            {
                
                ubicacion = s.Substring(0, s.IndexOf(' ') + 1).Trim();
                titulo = s.Substring(s.IndexOf(' ') + 1, (s.IndexOf(',') - s.IndexOf(' ')) - 1).Trim();//Resto uno para no incluir la coma 

                id = int.Parse(s.Split(',')[1]);
                ListaLibro.Add(new Libro(id, titulo, (ubicacion.ToLower().Contains("s") ? Libro.Ubicaciones.Sala : Libro.Ubicaciones.Sala)));
            }
        }

        private void CargarTransacciones(string rutaFichero)
        {
            string[] lineas = File.ReadAllLines(rutaFichero);
            string[] separar;
            string tipo, fecha = "";
            Libro libro;
            Persona persona;

            foreach (string linea in lineas)
            {
                tipo = linea.Substring(0, linea.IndexOf(" "));

                if (tipo.Equals("prestamo"))
                {
                    separar = linea.Split(',');
                    libro = BuscarLibro(int.Parse(separar[1]));
                    string nombre = linea.Substring(linea.IndexOf(" "), linea.IndexOf(", ")).Split(',')[0];
                    persona = BuscarUsuario(nombre);
                    if (libro != null && persona != null)
                    {
                        string infoLinea = linea.Substring(linea.IndexOf(" "), linea.IndexOf("#"));
                        string[] sacarFecha = linea.Split(',');
                        fecha = sacarFecha[2].Replace("#", " ").Trim();
                        ListaTransaccion.Add(new Transaccion(tipo, libro, persona, fecha));
                    }
                }
                else if (tipo.Equals("devolucion"))
                {
                    separar = linea.Split(' ');
                    libro = BuscarLibro(int.Parse(separar[1]));
                    if (libro != null)
                    {
                        ListaTransaccion.Add(new Transaccion(tipo, libro));
                    }
                }
            }
        }
        //TABPAGE USUARIOS---------------------------------------------------------------------
        //Muestra los usuario al iniciar al aplicacion
        private void MostrarUsuarios()
        {
            lvUsuarios.Items.Clear();
            foreach (Persona p in ListaUsuario)
            {
                ListViewItem lvItem = new ListViewItem();
                lvItem.Text = p.Tipo;

                lvItem.SubItems.Add(p.Nombre);
                lvItem.SubItems.Add(p.Departamento);
                lvItem.SubItems.Add(p.FechaSancion);
                switch (p.Tipo.ToLower())
                {
                    case "alumno":
                        lvItem.ImageIndex = 0;
                        break;
                    case "profesor":
                        lvItem.ImageIndex = 3;
                        break;
                    case "pas":
                        lvItem.ImageIndex = 2;
                        break;
                    default:
                        break;
                }

                lvUsuarios.Items.Add(lvItem);
            }
        }
        //Escrbir los usuarios en la lista incial
        private void CargarListaUsuarios(List<Persona> lista)
        {
            lvUsuarios.Items.Clear();
            foreach (Persona p in lista)
            {
                ListViewItem lvItem = new ListViewItem();
                lvItem.Text = p.Tipo;

                lvItem.SubItems.Add(p.Nombre);
                lvItem.SubItems.Add(p.Departamento);
                lvItem.SubItems.Add(p.FechaSancion);
                switch (p.Tipo.ToLower())
                {
                    case "alumno":
                        lvItem.ImageIndex = 0;
                        break;
                    case "profesor":
                        lvItem.ImageIndex = 3;
                        break;
                    case "pas":
                        lvItem.ImageIndex = 2;
                        break;
                    default:
                        break;
                }

                lvUsuarios.Items.Add(lvItem);
            }
        }

        private void BuscarUsuario()
        {
            String nombreBuscar = txtBxNombreUsuario.Text.Trim();
            List<Persona> listaAux = new List<Persona>();
            foreach (Persona p in ListaUsuario)
            {
                if (p.Nombre.ToUpper().Contains(nombreBuscar.ToUpper()))
                {
                    listaAux.Add(p);
                }
            }

            if (listaAux.Count <= 0 && nombreBuscar != "")
            {
                MessageBox.Show("No se han encontrado usuarios con ese nombre", "Error de búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBxNombreUsuario.Text = "";
            }
            else
            {
                CargarListaUsuarios(listaAux);
            }

            if (nombreBuscar == "") CargarListaUsuarios(ListaUsuario);
        }
        private Persona BuscarUsuario(string nombre)
        {
            Persona persona = null;
            foreach (Persona p in ListaUsuario)
            {
                if (p.Nombre.ToLower().Equals(nombre.Trim().ToLower()))
                {
                    if (p.Tipo.Equals("pas"))
                    {
                        persona = new Pas(p.Tipo, p.Nombre, p.Departamento);
                    }
                    else if (p.Tipo.Equals("profesor"))
                    {
                        persona = new Profesor(p.Tipo, p.Nombre, p.Departamento);
                    }
                    else if (p.Tipo.Equals("alumno"))
                    {
                        persona = new Alumno(p.Tipo, p.Nombre, p.Departamento);
                    }
                }
            }

            return persona;
        }

        //TABPAGE LIBROS-----------------------------------------------------------------------
        private void BuscarLibro(Libro l)
        {
            if (l.Titulo.ToLower().Contains(TxtBxTitulo.Text.ToLower()))
            {
                var item = LvLibro.Items.Add(l.Ubicacion);
                item.SubItems.Add(l.Titulo);
                item.SubItems.Add(l.ID.ToString());
            }
        }

        private Libro BuscarLibro(int id)
        {
            Libro libro = null;

            foreach (Libro l in ListaLibro)
            {
                if (l.ID == id)
                {
                    libro = new Libro(l.ID, l.Titulo, l.Ubicacion.Contains("s") ? Libro.Ubicaciones.Sala : Libro.Ubicaciones.Almacen);
                }
            }

            return libro;
        }

        public void MostrarLibros()
        {
            LvLibro.Items.Clear();
            foreach (Libro l in ListaLibro)
            {
                var item = LvLibro.Items.Add(l.Ubicacion);
                item.SubItems.Add(l.Titulo);
                item.SubItems.Add(l.ID.ToString());
            }
        }

        private void LvLibro_ColumnClick(object sender, ColumnClickEventArgs e)
        {

            // Set the ListViewItemSorter property to a new ListViewItemComparer 
            // object. Setting this property immediately sorts the 
            // ListView using the ListViewItemComparer object.
            this.LvLibro.ListViewItemSorter = new ListViewItemComparer(e.Column);

        }
        //TABPAGE MOVIMIENTOS------------------------------------------------------------------
        //SACA LAS TRANSACCIONES Y LAS MUESTRA AL INICIAR LA APLICACION
        private void MostrarMovimiento()
        {
            lvMovimientos.Items.Clear();
            foreach (Transaccion t in ListaTransaccion)
            {
                var item = lvMovimientos.Items.Add(t.Tipo);
                if (t.Tipo.Equals("prestamo"))
                {
                    item.SubItems.Add(t.Libro.Titulo);
                    item.SubItems.Add(t.Usuario.Nombre);
                    item.SubItems.Add(t.Usuario.Departamento);
                    item.SubItems.Add(t.Fecha);
                }
                else if (t.Tipo.Equals("devolucion"))
                {
                    item.SubItems.Add(t.Libro.Titulo);
                }
            }
        }
        //SACA LOS PRESTAMOS
        private void MostrarPrestamo()
        {
            lvMovimientos.Items.Clear();
            foreach (Transaccion t in ListaTransaccion)
            {
                if (t.Tipo.Equals("prestamo"))
                {
                    var item = lvMovimientos.Items.Add(t.Tipo);
                    item.SubItems.Add(t.Libro.Titulo);
                    item.SubItems.Add(t.Usuario.Nombre);
                    item.SubItems.Add(t.Usuario.Departamento);
                    item.SubItems.Add(t.Fecha);
                }
            }
        }
        //SACA LAS DEVOLUCIONES
        private void MostrarDevolucion()
        {
            lvMovimientos.Items.Clear();
            foreach (Transaccion t in ListaTransaccion)
            {
                if (t.Tipo.Equals("devolucion"))
                {
                    var item = lvMovimientos.Items.Add(t.Tipo);
                    item.SubItems.Add(t.Libro.Titulo);
                }
            }
        }

        //BUSCA DEPENDIENDO QUE OPCION ESTE SELECCIONADA EN LOS COMBOBOX
        private void BuscarPorOpcion(int opcMovimiento, int opcBusqueda, Transaccion t)
        {
            switch (opcBusqueda)
            {
                case TITULO_LIBRO:
                    //txtBxBuscarMovimiento.Show();
                    if (t.Libro.Titulo.ToLower().Contains(txtBxBuscarMovimiento.Text.ToLower()))
                    {
                        if (opcMovimiento == TODOS)
                        {
                            if (t.Tipo.Equals("prestamo"))
                            {
                                var item = lvMovimientos.Items.Add(t.Tipo);
                                item.SubItems.Add(t.Libro.Titulo);
                                item.SubItems.Add(t.Usuario.Nombre);
                                item.SubItems.Add(t.Usuario.Departamento);
                                item.SubItems.Add(t.Fecha);
                            }
                            else if (t.Tipo.Equals("devolucion"))
                            {
                                var item = lvMovimientos.Items.Add(t.Tipo);
                                item.SubItems.Add(t.Libro.Titulo);
                            }
                        }
                        else if (opcMovimiento == PRESTAMO)
                        {
                            if (t.Tipo.Equals("prestamo"))
                            {
                                var item = lvMovimientos.Items.Add(t.Tipo);
                                item.SubItems.Add(t.Libro.Titulo);
                                item.SubItems.Add(t.Usuario.Nombre);
                                item.SubItems.Add(t.Usuario.Departamento);
                                item.SubItems.Add(t.Fecha);
                            }
                        }
                        else if (opcMovimiento == DEVOLUCION)
                        {
                            if (t.Tipo.Equals("devolucion"))
                            {
                                var item = lvMovimientos.Items.Add(t.Tipo);
                                item.SubItems.Add(t.Libro.Titulo);
                            }
                        }
                    }
                    break;
                case USUARIO:
                    //txtBxBuscarMovimiento.Show();
                    if (opcMovimiento == TODOS || opcMovimiento == PRESTAMO)
                    {
                        if (t.Tipo.Equals("prestamo"))
                        {
                            if (t.Usuario.Nombre.ToLower().Contains(txtBxBuscarMovimiento.Text.ToLower()))
                            {
                                var item = lvMovimientos.Items.Add(t.Tipo);
                                item.SubItems.Add(t.Libro.Titulo);
                                item.SubItems.Add(t.Usuario.Nombre);
                                item.SubItems.Add(t.Usuario.Departamento);
                                item.SubItems.Add(t.Fecha);
                            }
                        }
                    }
                    break;
                case DEPARTAMENTO:
                    //txtBxBuscarMovimiento.Show();
                    if (opcMovimiento == TODOS || opcMovimiento == PRESTAMO)
                    {
                        if (t.Tipo.Equals("prestamo"))
                        {
                            if (t.Usuario.Departamento.ToLower().Contains(txtBxBuscarMovimiento.Text.ToLower()))
                            {
                                var item = lvMovimientos.Items.Add(t.Tipo);
                                item.SubItems.Add(t.Libro.Titulo);
                                item.SubItems.Add(t.Usuario.Nombre);
                                item.SubItems.Add(t.Usuario.Departamento);
                                item.SubItems.Add(t.Fecha);
                            }
                        }
                    }
                    break;
                case FECHA:
                    //txtBxBuscarMovimiento.Hide();
                    //calendar.Show();
                    DateTime fecha = calendar.SelectionStart;
                    string[] separar = fecha.ToString().Split(' ');
                    //txtBxBuscarMovimiento.Text = separar[0];

                    if (opcMovimiento == TODOS || opcMovimiento == PRESTAMO)
                    {
                        if (t.Tipo.Equals("prestamo"))
                        {
                            if (t.Fecha.Equals(separar[0]))
                            {
                                var item = lvMovimientos.Items.Add(t.Tipo);
                                item.SubItems.Add(t.Libro.Titulo);
                                item.SubItems.Add(t.Usuario.Nombre);
                                item.SubItems.Add(t.Usuario.Departamento);
                                item.SubItems.Add(t.Fecha);
                            }
                        }
                    }
                    break;
            }
        }
        //METODOS DE ELEMENTOS-----------------------------------------------------------------
        //OPCIONES DE TODOS LOS COMBOBOX
        private void boxOpc_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cmbBx = (ComboBox)sender;
            lvMovimientos.Items.Clear();
            switch (cmbBx.Name)
            {
                case "boxOpcMovimientos":
                    switch (cmbBx.SelectedIndex)
                    {
                        case TODOS://Todos
                            boxOpcBusqueda.Enabled = true;
                            lvMovimientos.Items.Clear();
                            MostrarMovimiento();

                            lvMovimientos.Items.Clear();
                            foreach (Transaccion t in ListaTransaccion)
                            {
                                BuscarPorOpcion(boxOpcMovimientos.SelectedIndex, boxOpcBusqueda.SelectedIndex, t);
                            }
                            break;
                        case PRESTAMO://Prestamos
                            boxOpcBusqueda.Enabled = true;
                            lvMovimientos.Items.Clear();
                            MostrarPrestamo();

                            lvMovimientos.Items.Clear();
                            foreach (Transaccion t in ListaTransaccion)
                            {
                                BuscarPorOpcion(boxOpcMovimientos.SelectedIndex, boxOpcBusqueda.SelectedIndex, t);
                            }
                            break;
                        case DEVOLUCION://Devoluciones
                            boxOpcBusqueda.SelectedIndex = TITULO_LIBRO;
                            boxOpcBusqueda.Enabled = false;
                            lvMovimientos.Items.Clear();
                            MostrarDevolucion();

                            lvMovimientos.Items.Clear();
                            foreach (Transaccion t in ListaTransaccion)
                            {
                                BuscarPorOpcion(boxOpcMovimientos.SelectedIndex, boxOpcBusqueda.SelectedIndex, t);
                            }
                            break;
                    }
                    break;

                case "boxOpcBusqueda":
                    if (cmbBx.SelectedIndex != FECHA)
                    {
                        txtBxBuscarMovimiento.Show();
                        calendar.Hide();
                    }
                    else
                    {
                        txtBxBuscarMovimiento.Hide();
                        calendar.Show();
                    }
                    break;
            }
        }
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            switch (btn.Name)
            {
                case "btnBuscarUsuario":
                    BuscarUsuario();
                    break;
                case "btnBuscarLibro":
                    LvLibro.Items.Clear();
                    foreach (Libro l in ListaLibro)
                    {
                        BuscarLibro(l);
                    }
                    break;
                case "btnBuscarMovimientos":
                    lvMovimientos.Items.Clear();
                    foreach (Transaccion t in ListaTransaccion)
                    {
                        BuscarPorOpcion(boxOpcMovimientos.SelectedIndex, boxOpcBusqueda.SelectedIndex, t);
                    }
                    break;
            }
        }
        //CALENDARIO---------------------------------------------------------------------------
        private void calendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            lvMovimientos.Items.Clear();
            foreach (Transaccion t in ListaTransaccion)
            {
                BuscarPorOpcion(boxOpcMovimientos.SelectedIndex, FECHA, t);
            }
        }
        //BOTONES LIBRO------------------------------------------------------------------------
        private void LvLibro_DoubleClick(object sender, EventArgs e)
        {
            FrmLibro form;
            int indice = -1;
            int contador = 0;
            bool noEncontrado = true;
            while (noEncontrado)
            {
                
                if (int.Parse(LvLibro.SelectedItems[0].SubItems[2].Text) == ListaLibro[contador].ID)
                {


                    indice = contador;
                    noEncontrado = false;
                }
                contador++;
            }

            if (indice != -1)
            {
                form = new FrmLibro(indice, this);
                form.Show();
            }
        }

        private void BtnAnadirLibro_Click(object sender, EventArgs e)
        {
            FrmLibro form = null;
            foreach (Form f in Application.OpenForms)//Hacer un metodo para comprobar si el formulario esta abierto
                                                     //Pasandole un tipo
            {
                if (f.GetType().Equals(typeof(FrmLibro)))
                {
                    form = (FrmLibro)f;
                }
            }

            if (form == null) form = new FrmLibro(-1, this);
            form.Show();
        }

        private void BtnBorrarLibro_Click(object sender, EventArgs e)
        {

            if (LvLibro.SelectedItems.Count == 1)
            {
                var item = LvLibro.SelectedItems[0];
                DialogResult dialog = MessageBox.Show("Seguro que quieres borrar el libro \"" + item.SubItems[1].Text + "\" con ID:  " + item.SubItems[2].Text, "Borrando Libro", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialog == DialogResult.Yes)
                {
                    int indice = -1;
                    int contador = 0;
                    bool noEncontrado = true;
                    while (noEncontrado)
                    {
                        if (int.Parse(LvLibro.SelectedItems[0].SubItems[2].Text) == ListaLibro[contador].ID)
                        {
                            indice = contador;
                            noEncontrado = false;
                        }
                        contador++;
                    }
                    Libro l = ListaLibro[indice];
                    bool sePuedeBorrar = true;
                    foreach (Transaccion t in ListaTransaccion)
                    {
                        if (t.Libro.Titulo.Equals(l.Titulo))
                        {
                            sePuedeBorrar = false;
                        }
                    }
                    if (sePuedeBorrar)
                    {

                        ListaLibro.RemoveAt(indice);
                    }
                    else
                    {
                        DialogResult dialog2 = MessageBox.Show("Este libro tiene prestamos asociados.¿Quieres eleminarlo?\n" +
                            "(Se eleminaran todas las transacciones con este libro)",
                            "Error borrado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (dialog2 == DialogResult.Yes)
                        {

                            List<Transaccion> copia = new List<Transaccion>();
                            copia.AddRange(ListaTransaccion);
                            foreach (Transaccion t in copia)
                            {
                                if (t.Libro.Titulo.Equals(l.Titulo))
                                {
                                    ListaTransaccion.Remove(t);
                                }
                            }

                            ListaLibro.RemoveAt(indice);
                        }
                    }

                    MostrarLibros();
                }
            }
            else
            {
                MessageBox.Show("Selecione un libro de la lista");
            }
        }
        //BOTONES USUARIO---------------------------------------------------------------------------
        private void BtnBorrarUser_Click(object sender, EventArgs e)
        {
            try
            {
                Persona pSelect = null;
                String nombreSelect = lvUsuarios.SelectedItems[0].SubItems[1].Text.Trim();
                foreach (Persona p in ListaUsuario)
                {
                    if (p.Nombre.ToUpper().Equals(nombreSelect.ToUpper())) pSelect = p;
                }
                DialogResult dialogResult = MessageBox.Show("¿Ddesea borrar a " + pSelect.Nombre + "?", "Borrar", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    bool sePuedeBorrar = true;
                    foreach (Transaccion t in ListaTransaccion)
                    {
                        if (t.Tipo.Equals("prestamo"))
                            if (t.Usuario.Nombre.Equals(pSelect.Nombre))
                            {
                                sePuedeBorrar = false;
                            }
                    }
                    if (sePuedeBorrar)
                    {

                        ListaUsuario.Remove(pSelect);
                    }
                    else
                    {
                        DialogResult dialog2 = MessageBox.Show("Esta persona tiene prestamos asociados.¿Quieres eleminarla?\n" +
                            "(Se eleminaran todas las transacciones de esta persona)", "Error borrado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (dialog2 == DialogResult.Yes)
                        {

                            List<Transaccion> copia = new List<Transaccion>();
                            copia.AddRange(ListaTransaccion);
                            foreach (Transaccion t in copia)
                            {
                                if (t.Tipo.Equals("prestamo"))
                                    if (t.Usuario.Nombre.Equals(pSelect.Nombre))
                                    {
                                        ListaTransaccion.Remove(t);
                                    }
                            }

                            ListaUsuario.Remove(pSelect);
                        }
                    }


                }

                CargarListaUsuarios(ListaUsuario);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("No hay un usuario seleccionado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch
            {
                MessageBox.Show("Error inesperado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAnadirUser_Click(object sender, EventArgs e)
        {
            FrmUsuario frmUsuario = new FrmUsuario();
            frmUsuario.ShowDialog();
            CargarListaUsuarios(ListaUsuario);
            
        }

        private void LvUsuarios_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListView lv = (ListView)sender;
            FrmUsuario frmUsuario = new FrmUsuario(lv.SelectedItems[0], lv.SelectedItems[0].Index);
            frmUsuario.ShowDialog();
            CargarListaUsuarios(ListaUsuario);
        }

        private void FrmPadre_FormClosing(object sender, FormClosingEventArgs e)
        {
            SobreEscribirUsuarios();
            SobreEscribirLibros();
        }

        private void SobreEscribirLibros()
        {

            StreamWriter writer = new StreamWriter(rutaFicheroLibros);
            foreach (Libro l in ListaLibro)
            {
                String line = l.Ubicacion.ToString().Trim() + " "
                    + l.Titulo.Trim() + ", " + l.ID;
                writer.WriteLine(line);
                
            }
            writer.Close();
        }

        private void SobreEscribirUsuarios()
        {
            //profesor Miguel Angel Fernandez, Informatica, #1/12/2021#
            StreamWriter writer = new StreamWriter(rutaFicheroUsuarios);
            foreach (Persona p in ListaUsuario)
            {
                String line = p.Tipo.Trim().ToLower() + " "
                    + p.Nombre.Trim() + ", " + p.Departamento.Trim();
                if (p.FechaSancion != null)
                {
                    line += ", #" + p.FechaSancion + "#";
                }
                writer.WriteLine(line);
                
            }
            writer.Close();
        }

        private void PrestamosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPrestamos prestamos = new FrmPrestamos();
            prestamos.ShowDialog();
        }

        private void devolucionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDevolucion devolucion = new FrmDevolucion();
            devolucion.Show();
        }
    }

    class ListViewItemComparer : IComparer
    {
        private int col;
        public ListViewItemComparer()
        {
            col = 0;
        }
        public ListViewItemComparer(int column)
        {
            col = column;
        }
        public int Compare(object x, object y)
        {
            return String.Compare(((ListViewItem)x).SubItems[col].Text, ((ListViewItem)y).SubItems[col].Text);
        }
    }
}

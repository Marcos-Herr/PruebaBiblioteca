using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaInterfaces
{
    internal class Transaccion
    {
        string tipo, fecha;
        Libro libro;
        Persona usuario;

        public string Tipo { get => tipo; set => tipo = value; }
        internal Libro Libro { get => libro; set => libro = value; }
        internal Persona Usuario { get => usuario; set => usuario = value; }
        public string Fecha { get => fecha; set => fecha = value; }

        public Transaccion() { }

        //TRANSACCIONES
        public Transaccion(string tipo, Libro libro, Persona usuario, string fecha)
        {
            Tipo = tipo;
            Libro = libro;
            Usuario = usuario;
            Fecha = fecha;
        }

        //DEVOLUCIONES
        public Transaccion (string tipo, Libro libro)
        {
            Tipo = tipo;
            Libro = libro;
        }

        public static void EscribirTransaccion(string cadena,Form f)
        {

            String rutaFicheroTransaccion = Environment.CurrentDirectory + @"\transacciones.txt";
            String[] lineasFichero = File.ReadAllLines(rutaFicheroTransaccion);
            String nuevaFecha = "fecha " + DateTime.Today.Day + ", " + DateTime.Today.Month + ", " + DateTime.Today.Year;
            bool existeFecha = false;
            foreach (String s in lineasFichero)
            {
                if (s.Equals(nuevaFecha))
                {
                    existeFecha = true;
                }
            }

            //StreamWriter writer = new StreamWriter(rutaFicheroTransaccion);
            if (!existeFecha)
            {
                using (StreamWriter sw = File.AppendText(rutaFicheroTransaccion))
                {
                    sw.WriteLine(nuevaFecha);
                }
            }
            using (StreamWriter sw = File.AppendText(rutaFicheroTransaccion))
            {
                sw.WriteLine(cadena);
                sw.Close();
            }

            MessageBox.Show("Transaccion registrada");
            f.Close();
        }
    }
}

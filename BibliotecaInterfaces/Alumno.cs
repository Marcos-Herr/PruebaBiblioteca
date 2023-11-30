using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaInterfaces
{
    class Alumno : Persona
    {
        public Alumno()
        {
        }

        public Alumno(string tipo, string nombre, string departamento) : base(tipo, nombre, departamento)
        {
            Tipo = tipo;
            Nombre = nombre;
            Departamento = departamento;
        }

        public DateTime CalcularSancion()
        {
            throw new NotImplementedException();
        }

        public DateTime CalcularFechaDevolucion(Libro l)
        {
            DateTime fechaDevolucion = DateTime.Today;

            if (l.Ubicacion.ToLower().Trim().Equals("almacen"))
            {
                fechaDevolucion = fechaDevolucion.AddDays(15);
            }
            else
            {
                fechaDevolucion = fechaDevolucion.AddDays(10);
            }
            return fechaDevolucion;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}

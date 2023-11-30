using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaInterfaces
{
    class Profesor : Persona
    {
        public Profesor()
        {
        }

        public Profesor(string tipo, string nombre, string departamento) : base(tipo, nombre, departamento)
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
                fechaDevolucion = fechaDevolucion.AddDays(45);
            }
            else
            {
                fechaDevolucion = fechaDevolucion.AddDays(30);
            }
            return fechaDevolucion;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}

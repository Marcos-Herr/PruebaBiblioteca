using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaInterfaces
{
    class Pas : Persona
    {
        public Pas()
        {
        }

        public Pas(string tipo, string nombre, string departamento) : base(tipo, nombre, departamento)
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
            DateTime fechaDevolucion = DateTime.Today.AddDays(15);
            
            return fechaDevolucion;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}

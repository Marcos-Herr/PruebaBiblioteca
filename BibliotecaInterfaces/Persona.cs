using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaInterfaces
{
    class Persona : IUsuario
    {
        private string tipo;
        private string nombre;
        private string departamento;
        private string fechaSancion;

        public Persona()
        {
        }

        //Ya que la fecha no es obligatoria, se modificará con Setter
        public Persona(string tipo, string nombre, string departamento)
        {
            this.Tipo = tipo;
            this.Nombre = nombre;
            this.Departamento = departamento;
        }

        public string Tipo { get => tipo; set => tipo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Departamento { get => departamento; set => departamento = value; }
        public string FechaSancion { get => fechaSancion; set => fechaSancion = value; }

        public DateTime CalcularFechaDevolucion(Libro l)
        {
            throw new NotImplementedException();
        }

        public DateTime CalcularSancion()
        {
            throw new NotImplementedException();
        }
    }
}

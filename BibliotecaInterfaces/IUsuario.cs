using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaInterfaces
{
    interface IUsuario
    {
        DateTime CalcularFechaDevolucion( Libro l); //l.ubicacion
        DateTime CalcularSancion();
    }
}

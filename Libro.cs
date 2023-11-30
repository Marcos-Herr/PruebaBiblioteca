using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaInterfaces
{
    class Libro : IComparable
    {
        [Flags]
        public enum Ubicaciones
        {
            Almacen = 0,
            Sala = 1
        }

        private String ubicacion, titulo;
        private int id;
       

        public Libro(int id, String titulo, Ubicaciones ubicacion)
        {
            this.ubicacion = (ubicacion == Ubicaciones.Almacen ? "Almacen" : "Sala");
            ID = id;
            Titulo = titulo;
        }

        public int ID { get => id; set => id = value; }
        public string Ubicacion { get => ubicacion; }

        public void setUbicacion(Ubicaciones ubicacion)
        {
            this.ubicacion = (ubicacion == Ubicaciones.Almacen ? "Almacen" : "Sala");
        }

        public int CompareTo(object obj)
        {
            return titulo.CompareTo(((Libro)obj).Titulo);
            //throw new NotImplementedException();
        }

        public string Titulo { get => titulo; set => titulo = value; }

    }
    
}

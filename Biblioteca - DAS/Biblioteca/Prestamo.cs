using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Prestamo
    {
        public Usuario Usuario { get; set; }
        public Libro Libro { get; set; }
        public DateTime FechaPrestamo { get; set; }
        public DateTime FechaDevolucion { get; set; }
        public bool Devuelto { get; set; }

        // Constructor
        public Prestamo(Usuario usuario, Libro libro, DateTime fechaPrestamo, DateTime fechaDevolucion)
        {
            Usuario = usuario;
            Libro = libro;
            FechaPrestamo = fechaPrestamo;
            FechaDevolucion = fechaDevolucion;
            Devuelto = false; // Por defecto, no ha sido devuelto.
        }
    }
}


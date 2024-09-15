using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Libro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int AñoPublicacion { get; set; }
        public string Genero { get; set; }

        // Constructor
        public Libro(string titulo, string autor, int añoPublicacion, string genero)
        {
            Titulo = titulo;
            Autor = autor;
            AñoPublicacion = añoPublicacion;
            Genero = genero;
        }
    }
}


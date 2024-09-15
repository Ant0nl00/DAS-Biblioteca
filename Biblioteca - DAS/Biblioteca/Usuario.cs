using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Usuario
    {
        public string Nombre { get; set; }
        public string Identificacion { get; set; }
        public string Contacto { get; set; }

        // Constructor
        public Usuario(string nombre, string identificacion, string contacto)
        {
            Nombre = nombre;
            Identificacion = identificacion;
            Contacto = contacto;
        }
    }
}


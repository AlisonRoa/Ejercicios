using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eje8_AlisonMacis
{
    internal class Actor
    {
        // Propiedades
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string NombreCompleto { get { return $"{Nombre} {Apellido}"; } }

        // Constructor
        public Actor(string nombre, string apellido)
        {
            Nombre = nombre;
            Apellido = apellido;
        }

        // Método ToString
        public override string ToString()
        {
            return "Actor: " + NombreCompleto;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eje8_AlisonMacis
{
    internal class Estudio
    {
        // Propiedades
        public string Nombre { get; set; }
        public string Direccion { get; set; }

        // Constructor
        public Estudio(string nombre, string direccion)
        {
            Nombre = nombre;
            Direccion = direccion;
        }

        // Método ToString
        public override string ToString()
        {
            return "Estudio: " + Nombre + " (" + Direccion + ")";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eje7_AlisonMacis
{
    // Crea una clase Persona que tenga una propiedad Nombre de tipo string,
    // un constructor que reciba el nombre como parámetro y sobrescriba el método ToString()

    internal class Persona
    {
        // Atributo
        string Nombre;

        // Constructor
        public Persona(string nombre)
        {
            Nombre = nombre;
        }

        // Propiedad
        public string Nombre1 { get => Nombre; set => Nombre = value; }

        // Método ToString
        public override string ToString()
        {
            return ("Nombre: " + Nombre);
        }
    }
}

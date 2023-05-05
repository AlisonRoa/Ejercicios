using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eje7_AlisonMacis
{
    // La clase Profesor tendrá un método Explicar que escribe en consola que
    // el profesor está explicando.
    // crear además dos constructores en las clases hijas que llamen al
    // constructor padre de la clase Persona.
    internal class Profesor : Persona
    {
        // Constructores
        public Profesor(string nombre) : base(nombre)
        {
            base.Nombre1 = nombre;
        }

        // Métodos
        public void Explicar()
        {
            Console.WriteLine("El profesor " + Nombre1 + " está explicando.");           
        }
    }
}

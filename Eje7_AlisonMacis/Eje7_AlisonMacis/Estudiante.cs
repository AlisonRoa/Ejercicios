using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eje7_AlisonMacis
{
    // La clase Estudiante tiene un método Estudiar que escribe por consola que
    // el estudiante está estudiando.
    // crear además dos constructores en las clases hijas que llamen al
    // constructor padre de la clase Persona.
    internal class Estudiante : Persona
    {
        // Constructores
        public Estudiante(string nombre) : base(nombre)
        {
            base.Nombre1 = nombre;
        }

        // Métodos
        public void Estudiar()
        {
            Console.WriteLine("El estudiante " + Nombre1 + " está estudiando." );
        }
    }
}

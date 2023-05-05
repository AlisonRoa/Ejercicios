using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eje8_AlisonMacis
{
    internal class Pelicula
    {
        // Propiedades
        public string Nombre { get; set; }
        public int Anio { get; set; }
        public List<Actor> Actores { get; set; } = new List<Actor>(); // Relacion actua
        public Estudio Estudio { get; set; } // Relacion Produce

        // Constructor
        public Pelicula(string nombre, int anio)
        {
            Nombre = nombre;
            Anio = anio;
        }

        // Método para añadir actores
        public void AgregarActor(Actor actor)
        {
            Actores.Add(actor);
        }

        // Método ToString
        public override string ToString()
        {
            string actoresStr = "";
            foreach (Actor actor in Actores)
            {
                actoresStr += actor.NombreCompleto + ", ";
            }
            actoresStr = actoresStr.TrimEnd(',', ' ');

            return ("Pelicula: " + Nombre + " (" + Anio + ") - Actores: " + actoresStr + " - Estudio: " + Estudio.Nombre);
        }

    }
}

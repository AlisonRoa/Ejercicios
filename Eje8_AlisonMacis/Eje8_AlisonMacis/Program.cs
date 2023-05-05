using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eje8_AlisonMacis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Estudio
            Console.WriteLine("Ingrese un estudio");
            string estudio = Console.ReadLine();
            Console.WriteLine("Ingrese donde está ubicado el estudio");
            string direccion = Console.ReadLine();

            Estudio est = new Estudio(estudio, direccion);

            // Actor
            Console.WriteLine("Ingrese el nombre de un actor");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el apellido del actor");
            string apellido = Console.ReadLine();

            Actor actor1 = new Actor(nombre, apellido);

            Console.WriteLine("Ingrese el nombre del segundo un actor");
            string nombre2 = Console.ReadLine();
            Console.WriteLine("Ingrese el apellido del segundo actor");
            string apellido2 = Console.ReadLine();

            Actor actor2 = new Actor(nombre2, apellido2);


            // Pelicula
            Console.WriteLine("Ingrese la pelicula");
            string peli = Console.ReadLine();
            Console.WriteLine("Ingrese el año");
            int anio = int.Parse(Console.ReadLine());

            Pelicula pelicula = new Pelicula(peli, anio);

            // Asignamos los actores y el estudio a la película
            pelicula.AgregarActor(actor1);
            pelicula.Estudio = est;

            // Imprimimos los objetos
            Console.WriteLine(pelicula);
            Console.WriteLine(actor1);
            Console.WriteLine(actor2);
            Console.WriteLine(est);

            Console.ReadKey();
        }
    }
}

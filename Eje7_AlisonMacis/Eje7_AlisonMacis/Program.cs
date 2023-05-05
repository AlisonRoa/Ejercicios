using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eje7_AlisonMacis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            // Tres nombres de personas al usuario y los almacene en un array de objetos de tipo Persona
            Persona[] personas = new Persona[3];

            // Solicitamos tres al usuario
            for (int i = 0; i < personas.Length; i++)
            {
                Console.Write("Introduce el nombre de la persona {0}: ", (i + 1));
                string nombre = Console.ReadLine();

                if (i == 0)
                {
                    personas[i] = new Profesor(nombre);
                }
                else
                {
                    personas[i] = new Estudiante(nombre);
                }
            }

            // Ejecutamos los métodos de Explicar y Estudiar
            for (int i = 0; i < personas.Length; i++)
            {
                if (personas[i] is Estudiante)
                {
                    ((Estudiante)personas[i]).Estudiar();
                }
                else if (personas[i] is Profesor)
                {
                    ((Profesor)personas[i]).Explicar();
                }
            }

            Console.ReadKey();
        }
    }
}

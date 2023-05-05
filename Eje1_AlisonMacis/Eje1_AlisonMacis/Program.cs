using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eje1_AlisonMacis
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instanciamos un nuevo objeto de la clase vehiculo
            Vehiculo vehiculo1 = new Vehiculo(1, "Chervolet", "Aveo", 5000, 15000, 2017);

            Console.WriteLine(vehiculo1.ToString());
            Console.ReadLine();

            Console.ReadKey();
        }
    }
}

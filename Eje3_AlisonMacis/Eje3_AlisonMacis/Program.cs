using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eje3_AlisonMacis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el tamaño de capacidad del disco duro en GB");
            int capacidad = int.Parse(Console.ReadLine());

            Computadora compu1 = new Computadora(capacidad);

            Console.WriteLine("La computadora se encenderá automaticamente\n\n");

            compu1.encender();

            Console.WriteLine("Ingrese los datos a añadir");
            int dato_a = int.Parse(Console.ReadLine());

            compu1.aniadirDatos(dato_a);

            Console.WriteLine("Ingrese los datos a eliminar");
            int dato_e = int.Parse(Console.ReadLine());

            compu1.eliminarDatos(dato_e);

            Console.WriteLine("La computadora se apagará automaticamente\n\n");
            compu1.apagar();

            Console.ReadKey();
        }
    }
}

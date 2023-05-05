using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eje6_AlisonMacis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\n***\nRectangulo \n");

            Console.WriteLine("Ingrese la ubicacion x: ");
            double x_rectangulo = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la ubicacion y: ");
            double y_rectangulo = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el lado 1 del rectangulo: ");
            double lado1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el lado 2 del rectangulo: ");
            double lado2 = double.Parse(Console.ReadLine());

            // Creamos una instancia de Rectangulo
            Rectangulo rectangulo = new Rectangulo(x_rectangulo, y_rectangulo, lado1, lado2);

            Console.WriteLine("\n\n\n");

            // Imprimimos los atributos y métodos de Rectangulo
            Console.WriteLine(rectangulo.ToString());  // Ubicación
            Console.WriteLine("Área: " + rectangulo.Area());  // Área
            Console.WriteLine("Perímetro: " + rectangulo.Perimetro());  // Perímetro

            Console.WriteLine("\n\n***\nCirculo \n");

            Console.WriteLine("Ingrese la ubicacion x: ");
            double x_circulo = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la ubicacion y: ");
            double y_circulo = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el radio del Circulo: ");
            double radio = double.Parse(Console.ReadLine());

            // Creamos una instancia de Circulo
            Circulo circulo = new Circulo(x_circulo, y_circulo, radio);

            Console.WriteLine("\n\n\n");

            // Imprimimos los atributos y métodos de Circulo
            Console.WriteLine(circulo.ToString());  // Ubicación
            Console.WriteLine("Área: " + circulo.Area());  // Área
            Console.WriteLine("Perímetro: " + circulo.Perimetro());

            Console.ReadKey();
        }
    }
}

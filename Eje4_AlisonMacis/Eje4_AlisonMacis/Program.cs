using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eje4_AlisonMacis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese los detalles del Auto:");
            Console.Write("Id: ");
            int idAuto = int.Parse(Console.ReadLine());
            Console.Write("Marca: ");
            string marcaAuto = Console.ReadLine();
            Console.Write("Modelo: ");
            string modeloAuto = Console.ReadLine();
            Console.Write("Kilometraje: ");
            int kmAuto = int.Parse(Console.ReadLine());
            Console.Write("Precio: ");
            decimal precioAuto = decimal.Parse(Console.ReadLine());
            Console.Write("Año: ");
            int annioAuto = int.Parse(Console.ReadLine());
            Console.Write("Airbag (true/false): ");
            bool airbagAuto = bool.Parse(Console.ReadLine());

            
            Auto auto = new Auto(idAuto, marcaAuto, modeloAuto, kmAuto, precioAuto, annioAuto, airbagAuto);

            
            Console.WriteLine("\nDetalles del Auto:");
            Console.WriteLine(auto.ToString());


            Console.WriteLine("\nIngrese los detalles de la Moto:");
            Console.Write("Id: ");
            int idMoto = int.Parse(Console.ReadLine());
            Console.Write("Marca: ");
            string marcaMoto = Console.ReadLine();
            Console.Write("Modelo: ");
            string modeloMoto = Console.ReadLine();
            Console.Write("Kilometraje: ");
            int kmMoto = int.Parse(Console.ReadLine());
            Console.Write("Precio: ");
            decimal precioMoto = decimal.Parse(Console.ReadLine());
            Console.Write("Año: ");
            int annioMoto = int.Parse(Console.ReadLine());
            Console.Write("Sidecar (true/false): ");
            bool sidecarMoto = bool.Parse(Console.ReadLine());

         
            Moto moto = new Moto(idMoto, marcaMoto, modeloMoto, kmMoto, precioMoto, annioMoto, sidecarMoto);

       
            Console.WriteLine("\nDetalles de la Moto:");
            Console.WriteLine(moto.ToString());

            Console.ReadKey();
        }
    }
}

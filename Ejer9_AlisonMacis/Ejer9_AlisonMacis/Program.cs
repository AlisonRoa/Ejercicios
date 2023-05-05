using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer9_AlisonMacis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Camionero
            Console.WriteLine("Ingrese el nombre del camionero");
            string nombre = Console.ReadLine();

            Console.WriteLine("Ingrese el numero");
            string num = Console.ReadLine();

            Console.WriteLine("Ingrese el salario");
            decimal sal = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la dirección");
            string direc = Console.ReadLine();

            Console.WriteLine("Ingrese el pais");
            string pais = Console.ReadLine();

            Console.WriteLine("Ingrese el RFC");
            string rfc = Console.ReadLine();

            Camionero camionero1 = new Camionero(nombre, num, sal, direc, pais, rfc);

            // Camion
            Console.WriteLine("Ingrese la potencia del camion");
            int potencia = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la matricula");
            string matricula = Console.ReadLine();

            Console.WriteLine("Ingrese el modelo");
            string modelo = Console.ReadLine();

            Console.WriteLine("Ingrese el tipo");
            string tipo = Console.ReadLine();

            Camion camion1 = new Camion( potencia, matricula, modelo, tipo);

            camion1.Conductor = camionero1;
            camionero1.Conduce.Add(camion1);

            // Ciudad
            Console.WriteLine("Ingrese el codigo de la ciudad");
            int cod = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el nombre de la ciudad");
            string nombre_c = Console.ReadLine();

            Ciudad ciudad1 = new Ciudad(cod, nombre_c);

            // Paquete
            Console.WriteLine("Ingrese el codigo del paquete");
            int cod_p= int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la descripcion");
            string desc= Console.ReadLine();

            Console.WriteLine("Ingrese el destinatario");
            string destinatario = Console.ReadLine();

            Console.WriteLine("Ingrese la direccion");
            string direccion_p = Console.ReadLine();

            Paquete paquete1 = new Paquete( cod_p, desc, destinatario, direccion_p, ciudad1);
            camionero1.Distribuye.Add(paquete1);

            Console.WriteLine("El camionero {0} conduce el camión con matrícula {1} que lleva el paquete {2} a la ciudad de {3}.", camionero1.Nombre, camion1.Matricula, paquete1.Codigo, paquete1.Destinado.Nombre);
        }
    }
}

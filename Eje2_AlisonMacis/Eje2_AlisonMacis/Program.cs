using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eje2_AlisonMacis
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CasaComercial cc2 = new CasaComercial("autolote el chele", "contacto@elchele.com", 0, new List<Vehiculo>());
            cc2.aniadirVehiculo(new Vehiculo(2, "toyota", "prado", 2000, 5000, 150000));

            Console.WriteLine("\n\nA continuación, De el nombre de la casa comercial: ");
            string nombre = Console.ReadLine();

            Console.WriteLine("Ingresa el email: ");
            string email = Console.ReadLine();

            CasaComercial cc = new CasaComercial(nombre, email, 0, new List<Vehiculo>());

            Console.WriteLine("\n\nA continuacion de la información del primer vehiculo a añadir: ");
            Console.WriteLine("Modelo: ");
            string model = Console.ReadLine();
            Console.WriteLine("Marca: ");
            string marca = Console.ReadLine();
            Console.WriteLine("Kilometraje: ");
            int km = int.Parse(Console.ReadLine());
            Console.WriteLine("Annio: ");
            int annio = int.Parse(Console.ReadLine());
            Console.WriteLine("Precio: ");
            decimal precio = decimal.Parse(Console.ReadLine());

            // Info del nuevo vehivulo usando añadirvehiculo
            cc.aniadirVehiculo(new Vehiculo(1, marca, model, km, precio, annio));

            Console.WriteLine("\n\nA continuación se mostraran todos los vehiculos de la lista: ");
            cc.mostrarVehiculos();

            Console.WriteLine("\n\nDesea vaciar la lista: S/N");
            string resp = Console.ReadLine();

            if (resp == "S" || resp == "s")
            {
                cc.vaciarVehiculo();
            }

            Console.WriteLine("\n\nDesea borrar un vehiculo del consesionario? S/N");
            string resp2 = Console.ReadLine();

            if (resp2 == "S" || resp2 == "s")
            {
                Console.WriteLine("Ingrese el numero de Id de su vehiculo");
                int id = int.Parse(Console.ReadLine());

                if (id == 1)
                {
                    Console.WriteLine("\nIngrese los datos del vehiculo que desea borrar");

                    Console.WriteLine("Modelo: ");
                    string model_e = Console.ReadLine();
                    Console.WriteLine("Marca: ");
                    string marca_e = Console.ReadLine();
                    Console.WriteLine("Kilometraje: ");
                    int km_e = int.Parse(Console.ReadLine());
                    Console.WriteLine("Annio: ");
                    int annio_e = int.Parse(Console.ReadLine());
                    Console.WriteLine("Precio: ");
                    decimal precio_e = decimal.Parse(Console.ReadLine());

                    Vehiculo vehiculo_eliminar = new Vehiculo(1, marca_e, model_e, km_e, precio_e, annio_e);
                    cc.eliminarVehiculo(vehiculo_eliminar);
                }

                if (id == 2)
                {
                    Console.WriteLine("\nIngrese los datos del vehiculo que desea borrar");

                    Console.WriteLine("Modelo: ");
                    string model_e = Console.ReadLine();
                    Console.WriteLine("Marca: ");
                    string marca_e = Console.ReadLine();
                    Console.WriteLine("Kilometraje: ");
                    int km_e = int.Parse(Console.ReadLine());
                    Console.WriteLine("Annio: ");
                    int annio_e = int.Parse(Console.ReadLine());
                    Console.WriteLine("Precio: ");
                    decimal precio_e = decimal.Parse(Console.ReadLine());

                    Vehiculo vehiculo_eliminar = new Vehiculo(2, marca_e, model_e, km_e, precio_e, annio_e);
                    cc.eliminarVehiculo(vehiculo_eliminar);
                }

                else
                {
                    Console.WriteLine("No se encontró el vehiculo");
                }
            }

            Console.ReadKey();
        }
    }
}

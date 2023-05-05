using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eje2_AlisonMacis
{
    class CasaComercial
    {
        // Campos de la Casa Comercial
        string nombre;
        string email;
        int total;

        // Esto es composición, porque casa comercial contiene una lista de objetos tipo vehiculos
        List<Vehiculo> vehiculos;

        // Constructor
        public CasaComercial(string nombre, string email, int total, List<Vehiculo> vehiculos)
        {
            this.nombre = nombre;
            this.email = email;
            this.total = total;
            this.vehiculos = vehiculos;
        }

        // Propiedades
        public string Nombre { get => nombre; set => nombre = value; }
        public string Email { get => email; set => email = value; }
        public int Total { get => total; set => total = value; }
        internal List<Vehiculo> Vehiculos { get => vehiculos; set => vehiculos = value; }

        // Añadimos vehiculos
        public void aniadirVehiculo(Vehiculo v)
        {
            try
            {
                // añadir un nuevo vehículo
                this.vehiculos.Add(v);
                // aumentar el total de vehículos
                this.total++;

                Console.WriteLine("Se ha anadido un vehiculo: ");
            }

            catch (Exception ex)
            {
                Console.WriteLine("No se pudo añadir debido a: " + ex.Message);
                Console.ReadLine();
            }

        }

        // mostrarVehiculos(): Muestra la lista de vehículos registrados
        public void mostrarVehiculos()
        {
            foreach (var item in this.vehiculos)
            {
                Console.WriteLine(" -- -- -- -- -- -- ");
                Console.WriteLine(item);
                item.ToString();
            }
        }

        // vaciarVehiculo(): Elimina todos los vehículos registrados
        public void vaciarVehiculo()
        {
            Console.WriteLine("Esta seguro que desea eliminar todos los vehiculos de la lista?: S/N");
            string resp = Console.ReadLine();

            if (resp == "S" || resp == "s")
            {
                vehiculos = new List<Vehiculo>();
                this.total = 0;

                Console.WriteLine("Se han eliminado los objetos correctamente");
            }

            else
            {
                Console.WriteLine("No se elimino. Hay {0} vehiculos registrados", total);
            }
        }

        // Eliminar un Elemento
        public void eliminarVehiculo(Vehiculo v)
        {
            vehiculos.Remove(v);
            total--;

            Console.WriteLine("Se ha eliminado un registro.");
        }
    }
}

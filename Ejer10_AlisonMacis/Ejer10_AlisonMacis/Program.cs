using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer10_AlisonMacis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creamos un cliente
            Cliente cliente = new Cliente();
            cliente.Nombre = "Juan";
            cliente.Edad = 30;
            cliente.TelefonoDeContacto = "555-1234";

            // Creamos un empleado
            Empleado empleado = new Empleado();
            empleado.Nombre = "Pedro";
            empleado.Edad = 35;
            empleado.SueldoBruto = 50000;

            // Creamos un directivo
            Directivo directivo = new Directivo();
            directivo.Nombre = "Ana";
            directivo.Edad = 40;
            directivo.SueldoBruto = 100000;
            directivo.Categoria = "Gerente";

            // Creamos una empresa
            Empresa empresa = new Empresa();
            empresa.Nombre = "Mi Empresa";
            empresa.Empleado = empleado;

            // Mostramos los datos
            cliente.Mostrar();
            empleado.Mostrar();
            Console.WriteLine("Salario neto: " + empleado.CalcularSalarioNeto());
            directivo.Mostrar();
            Console.WriteLine("Nombre de la empresa: " + empresa.Nombre);
            Console.WriteLine("Nombre del empleado: " + empresa.Empleado.Nombre);
        }
    }
}

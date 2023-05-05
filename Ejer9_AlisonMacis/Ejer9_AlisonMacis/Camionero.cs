using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer9_AlisonMacis
{
    internal class Camionero
    {
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public decimal Salario { get; set; }
        public string Direccion { get; set; }
        public string Poblacion { get; set; }
        public string Rfc { get; set; }
        public List<Camion> Conduce { get; set; }
        public List<Paquete> Distribuye { get; set; }

        public Camionero(string nombre, string telefono, decimal salario, string direccion, string poblacion, string rfc)
        {
            Nombre = nombre;
            Telefono = telefono;
            Salario = salario;
            Direccion = direccion;
            Poblacion = poblacion;
            Rfc = rfc;
            Conduce = new List<Camion>();
            Distribuye = new List<Paquete>();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer10_AlisonMacis
{
    internal class Empresa
    {
        private string nombre;
        private Empleado empleado;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public Empleado Empleado
        {
            get { return empleado; }
            set { empleado = value; }
        }
    }
}

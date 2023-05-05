using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer10_AlisonMacis
{
    internal class Empleado : Persona
    {
        private double sueldoBruto;

        public double SueldoBruto
        {
            get { return sueldoBruto; }
            set { sueldoBruto = value; }
        }

        public override void Mostrar()
        {
            base.Mostrar();
            Console.WriteLine("Sueldo Bruto: " + sueldoBruto);
        }

        public double CalcularSalarioNeto()
        {
            // Asumamos que el salario neto es el 80% del bruto
            return sueldoBruto * 0.8;
        }
    }
}

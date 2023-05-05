using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eje6_AlisonMacis
{
    internal class Rectangulo : Forma
    {
        // Atributos
        private double lado1;
        private double lado2;

        // Constructor
        public Rectangulo(double x, double y, double lado1, double lado2) : base(x, y)
        {
            this.lado1 = lado1;
            this.lado2 = lado2;
        }
        protected double Lado1 { get => lado1; set => lado1 = value; }
        protected double Lado2 { get => lado2; set => lado2 = value; }

        // Métodos
        public override double Area()
        {
            return lado1 * lado2;
        }

        public override double Perimetro()
        {
            return 2 * (lado1 + lado2);
        }
    }
}

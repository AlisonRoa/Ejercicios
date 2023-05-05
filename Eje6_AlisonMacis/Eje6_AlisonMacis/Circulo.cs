using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eje6_AlisonMacis
{
    internal class Circulo : Forma
    {
        // Atributos
        protected double radio;

        // Constructor
        public Circulo(double x, double y, double radio) : base(x, y)
        {
            this.radio = radio;
        }

        // Métodos
        public override double Area()
        {
            return Math.PI * radio * radio;
        }

        public override double Perimetro()
        {
            return 2 * Math.PI * radio;
        }
    }
}

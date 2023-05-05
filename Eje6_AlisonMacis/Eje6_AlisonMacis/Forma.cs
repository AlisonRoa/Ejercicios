using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eje6_AlisonMacis
{
    internal class Forma
    {
        // Atributos
        private Ubicacion c;

        // Constructor
        public Forma(double x, double y)
        {
            c = new Ubicacion(x, y);
        }

        internal Ubicacion C { get => c; set => c = value; }

        // Métodos
        public override string ToString()
        {
            return $"Ubicación: ({c.X}, {c.Y})";
        }

        public virtual double Area()
        {
            return 0.0;
        }

        public virtual double Perimetro()
        {
            return 0.0;
        }
    }
}

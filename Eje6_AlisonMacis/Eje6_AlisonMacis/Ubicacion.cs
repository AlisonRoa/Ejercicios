using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eje6_AlisonMacis
{
    internal class Ubicacion
    {
        // Atributos
        private double x;
        private double y;

        // Propiedades
        public double X
        {
            get { return x; }
            set { x = value; }
        }

        public double Y
        {
            get { return y; }
            set { y = value; }
        }

        // Constructor
        public Ubicacion(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
    }
}

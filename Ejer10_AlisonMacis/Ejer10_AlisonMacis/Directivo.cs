using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer10_AlisonMacis
{
    internal class Directivo : Empleado
    {
        private string categoria;

        public string Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }

        public override void Mostrar()
        {
            base.Mostrar();
            Console.WriteLine("Categoria: " + categoria);
        }
    }
}

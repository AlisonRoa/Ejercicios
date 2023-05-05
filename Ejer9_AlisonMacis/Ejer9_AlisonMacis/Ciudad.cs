using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer9_AlisonMacis
{
    internal class Ciudad
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }

        public Ciudad(int codigo, string nombre)
        {
            Codigo = codigo;
            Nombre = nombre;
        }
    }
}

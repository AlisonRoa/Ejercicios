using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer9_AlisonMacis
{
    internal class Paquete
    {
        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public string Destinatario { get; set; }
        public string Direccion { get; set; }
        public Ciudad Destinado { get; set; }

        public Paquete(int codigo, string descripcion, string destinatario, string direccion, Ciudad destinado)
        {
            Codigo = codigo;
            Descripcion = descripcion;
            Destinatario = destinatario;
            Direccion = direccion;
            Destinado = destinado;
        }
    }
}

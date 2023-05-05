using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer9_AlisonMacis
{
    internal class Camion
    {
        public int Potencia { get; set; }
        public string Matricula { get; set; }
        public string Modelo { get; set; }
        public string Tipo { get; set; }
        public Camionero Conductor { get; set; }

        public Camion(int potencia, string matricula, string modelo, string tipo)
        {
            Potencia = potencia;
            Matricula = matricula;
            Modelo = modelo;
            Tipo = tipo;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eje1_AlisonMacis
{
    class Vehiculo
    {
        // Definimos Los campos de la clases
        int id;
        string marca;
        string model;
        int km;
        decimal precio;
        int annio;

        public Vehiculo(int id, string marca, string model, int km, decimal precio, int annio)
        {
            this.Id = id;
            this.Marca = marca;
            this.Model = model;
            this.Km = km;
            this.Precio = precio;
            this.Annio = annio;
        }

        // propiedades
        public int Id { get => id; set => id = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Model { get => model; set => model = value; }
        public int Km { get => km; set => km = value; }
        public decimal Precio { get => precio; set => precio = value; }
        public int Annio { get => annio; set => annio = value; }

        public override string ToString()
        {
            return "Modelo: " + Model + "\nMarca: " + Marca + "\nKilometraje: " + Km + "\nPrecio: " + Precio + "\nAnnio: " + Annio;
        }
    }
}

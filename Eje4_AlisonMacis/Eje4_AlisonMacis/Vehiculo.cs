using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eje4_AlisonMacis
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
    class Auto : Vehiculo
    {
        // Atributos
        bool airbag;

        // Constructor
        public Auto(int id, string marca, string model, int km, decimal precio, int annio, bool airbag) : base(id, marca, model, km, precio, annio)
        {
            this.airbag = airbag;
        }

        // propiedades
        public bool Airbag { get => airbag; set => airbag = value; }

        // Métodos
        public override string ToString()
        {
            if (airbag)
            {
                return "Modelo: " + base.Model + "\nMarca: " + base.Marca + "\nKilometraje: " + base.Km + "\nPrecio: " + (base.Precio + (decimal)200) + "\nAnnio: " + base.Annio;
            }
            else
            {
                return "Modelo: " + base.Model + "\nMarca: " + base.Marca + "\nKilometraje: " + base.Km + "\nPrecio: " + base.Precio + "\nAnnio: " + base.Annio;
            }

        }
      
    }

    class Moto : Vehiculo
    {
        // Atributos
        bool sidecar;

        // Constructor
        public Moto(int id, string marca, string model, int km, decimal precio, int annio, bool sidecar) : base(id, marca, model, km, precio, annio)
        {
            this.sidecar = sidecar;
        }

        // propiedades
        public bool Sidecar { get => sidecar; set => sidecar = value; }

        // Métodos
        public override string ToString()
        {
            if (sidecar)
            {
                return "Modelo: " + base.Model + "\nMarca: " + base.Marca + "\nKilometraje: " + base.Km + "\nPrecio: " + (base.Precio + (decimal)50) + "\nAnnio: " + base.Annio;
            }
            else
            {
                return "Modelo: " + base.Model + "\nMarca: " + base.Marca + "\nKilometraje: " + base.Km + "\nPrecio: " + base.Precio + "\nAnnio: " + base.Annio;
            }

        }
    }
}

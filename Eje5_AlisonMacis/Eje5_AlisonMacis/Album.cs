using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eje5_AlisonMacis
{
    internal class Album
    {
        // Campos
        int id;
        string nombre;
        DateTime fecha_creacion;
        List<Foto> ListaFotos;

        // constructor
        public Album(int id, string nombre, DateTime fecha_creacion, List<Foto> listaFotos)
        {
            this.id = id;
            this.nombre = nombre;
            this.fecha_creacion = fecha_creacion;
            ListaFotos = listaFotos;
        }

        // propiedades
        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public DateTime Fecha_creacion { get => fecha_creacion; set => fecha_creacion = value; }
        internal List<Foto> ListaFotos1 { get => ListaFotos; set => ListaFotos = value; }


        // metodos
        // aniadirFoto(Foto f): Permite añadir una nueva foto 
        public void AniadirFoto(Foto f)
        {
            ListaFotos.Add(f);
            Console.WriteLine("Se ha añadido correctamente...");
        }

        // mostrarFoto(): Muestra la lista de las foto registradas
        public void MostrarFotos()
        {
            if (ListaFotos != null)
            {
                Console.WriteLine("\n\nMostrando Fotos...");

                foreach (Foto f in ListaFotos)
                {
                    Console.WriteLine(f);
                    Console.WriteLine("*******************************");
                }                
            }
            else
            {
                Console.WriteLine("No hay fotos por mostrar");
            }
        }

        // vaciarAlbum(): Elimina todos las fotos registradas
        public void VaciarAlbum()
        {
            Console.WriteLine("\n\nVaciando Album...");
            ListaFotos.Clear();
            Console.WriteLine("Se ha vaciado correctamente...");
        }

        // eliminarFoto(Foto f)
        public void EliminarFoto(Foto f)
        {
            ListaFotos.Remove(f);
            Console.WriteLine("Se ha eliminado correctamente...");
        }

        // TamanoAlbum(): Muestra el tamaño en GB del álbum.
        public decimal TamanoAlbum()
        {
            Console.WriteLine("Mostrando el tamaño...");
            decimal tamanoTotalMb = ListaFotos.Sum(f => f.Tamaño_mb);
            return tamanoTotalMb / (decimal) 1024.0; // Convertir a GB
        }
    }
}

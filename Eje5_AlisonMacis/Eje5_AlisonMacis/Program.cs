using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Eje5_AlisonMacis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creamos algunas fotos        
            Console.WriteLine("Ingrese 3 fotos: ");
            Console.WriteLine("Foto1 ");

            // Foto 1
            Console.WriteLine("Id: ");
            int id1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Tamaño: ");
            decimal tamaño1 = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Fecha: ");
            DateTime fecha1 = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Comentario: ");
            string comentario1 = Console.ReadLine();

            Foto foto1 = new Foto(id1, tamaño1, fecha1, comentario1);

            // Foto 2
            Console.WriteLine("Foto2 ");

            Console.WriteLine("Id: ");
            int id2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Tamaño: ");
            decimal tamaño2 = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Fecha: ");
            DateTime fecha2 = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Comentario: ");
            string comentario2 = Console.ReadLine();

            Foto foto2 = new Foto(id2, tamaño2, fecha2, comentario2);

            // Foto 3
            Console.WriteLine("Foto3 ");

            Console.WriteLine("Id: ");
            int id3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Tamaño: ");
            decimal tamaño3 = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Fecha: ");
            DateTime fecha3 = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Comentario: ");
            string comentario3 = Console.ReadLine();

            Foto foto3 = new Foto(id3, tamaño3, fecha3, comentario3);            

            // Album
            Console.WriteLine("\n\nIngrese el nombre del album");
            string album = Console.ReadLine();
            Console.WriteLine("Ingrese la fecha de creacion del album");
            DateTime fecha = DateTime.Parse(Console.ReadLine());

            Album album1 = new Album(1, album, fecha, new List<Foto> { foto1, foto2, foto3 });

            // Añadir
            album1.AniadirFoto(foto1);
            album1.AniadirFoto(foto2);
            album1.AniadirFoto(foto3);

            // Mostrar            
            album1.MostrarFotos();

            // Eliminar
            Console.WriteLine("\n\nEliminando la segunda foto");
            album1.EliminarFoto(foto2);

            // Mostrar
            Console.WriteLine("\n\nFotos en el álbum (actualizado): ");
            album1.MostrarFotos();

            // Mostrar 
            decimal tamanoGb = album1.TamanoAlbum();
            Console.WriteLine("\n\nEl Tamaño del álbum {0} es de {1} GB", album1.Nombre, tamanoGb);

            // Vaciar el álbum
            album1.VaciarAlbum();

            // Mostrar las fotos del álbum vacío
            Console.WriteLine("\n\nFotos en el álbum {0}: (vacío)", album1.Nombre);
            album1.MostrarFotos();

            Console.ReadKey();
        }
    }
}

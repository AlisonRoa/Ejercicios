using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eje5_AlisonMacis
{
    internal class Foto
    {
        // campos
        int id_foto;
        decimal tamaño_mb;
        DateTime fecha_creacion;
        string comentario;

        // constructor
        public Foto(int id_foto, decimal tamaño_mb, DateTime fecha_creacion, string comentario)
        {
            this.id_foto = id_foto;
            this.tamaño_mb = tamaño_mb;
            this.fecha_creacion = fecha_creacion;
            this.comentario = comentario;
        }

        // propiedades
        public int Id_foto { get => id_foto; set => id_foto = value; }
        public decimal Tamaño_mb { get => tamaño_mb; set => tamaño_mb = value; }
        public DateTime Fecha_creacion { get => fecha_creacion; set => fecha_creacion = value; }
        public string Comentario { get => comentario; set => comentario = value; }

        // metodo
        public override string ToString()
        {
            Console.WriteLine("Detalles de la foto: ");
            return "Id Foto: " + id_foto + "\nTamaño: " + Tamaño_mb + "\nFecha de Creación: " + fecha_creacion + "\nComentarios: " + comentario;
        }
    }
}

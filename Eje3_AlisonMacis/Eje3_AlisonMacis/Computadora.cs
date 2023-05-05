using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Eje3_AlisonMacis
{
    internal class Computadora
    {
        decimal capacidad_disco;
        decimal espacio_disponible;
        bool encendido = false;

        public Computadora(decimal capacidad_disco, decimal espacio_disponible, bool encendido)
        {
            this.capacidad_disco = capacidad_disco;
            this.espacio_disponible = espacio_disponible;
            this.encendido = encendido;
        }

        public decimal Capacidad_disco { get => capacidad_disco; set => capacidad_disco = value; }
        public decimal Espacio_disponible { get => espacio_disponible; set => espacio_disponible = value; }
        public bool Encendido { get => encendido; set => encendido = value; }

        // — Computadora : Constructor.
        /* capacidad_disco" que representa la capacidad total del disco en gigabytes.
         * Este valor se asigna tanto a "capacidad_disco" como a "espacio_disponible"
         * al inicio, ya que al encender la Computadora, todo el espacio está disponible.*/
        public Computadora(int capacidad_disco)
        {
            this.capacidad_disco = capacidad_disco;
            espacio_disponible = 0; // Suponemos que está totalmente vacio
            encendido = false;
        }

        /* – aniadirDatos(int datos): añade información al disco duro, si supera el espacio 
         * disponible del disco, el tamaño del disco será el máximo posible. 
         * Solo si esta encendida la Computadora.*/
        public void aniadirDatos(int datos)
        {
            // Solo si esta encendida la Computadora
            if (encendido)
            {
                // Defino el espacio disponible. No se pueden restar decimales por eso se convierte a int.
                int espacio_libre = (int)capacidad_disco - (int)espacio_disponible; // capacidad menos 0

                // si supera el espacio disponible del disco, añade datos
                if (datos <= espacio_libre)
                {
                    espacio_disponible += datos;
                    Console.WriteLine("Se añadierón los datos correctamente.");
                }
                else
                {
                    espacio_disponible = capacidad_disco;
                    Console.WriteLine("El disco duro está lleno.");
                }
            }
            else
            {
                Console.WriteLine("La Computadora está apagada.");
            }
        }

        /* – eliminarDatos(int datos): elimina información al disco duro, si el tamaño del disco 
         * es menor que 0, el tamaño del disco se quedara a 0. 
         * Solo si esta encendida la Computadora.*/
        public void eliminarDatos(int datos)
        {
            // Solo si esta encendida la Computadora
            if (encendido)
            {
                if (datos <= espacio_disponible)
                {
                    espacio_disponible = espacio_disponible - datos;
                    Console.WriteLine("Se eliminaron los datos correctamente.");
                }

                // si el tamaño del disco es menor que 0, el tamaño del disco se quedara a 0
                else
                {
                    espacio_disponible = 0;
                    Console.WriteLine("El disco duro está vacío.");
                }
            }
            else
            {
                Console.WriteLine("La Computadora está apagada.");
            }
        }

        /* – encender() : enciende la Computadora y muestra un mensaje en pantalla de Bienvenida. */
        public void encender()
        {
            if (!encendido)
            {
                encendido = true;
                Console.WriteLine("¡¡¡Bienvenida a la Computadora!!!");
            }
            else
            {
                Console.WriteLine("La Computadora ya está encendida.");
            }
        }

        /* – apagar(): apaga la Computadora y muestra un mensaje en pantalla de despedida*/
        public void apagar()
        {
            if (encendido)
            {
                encendido = false;
                Console.WriteLine("¡¡¡Nos vemos luego!!!");
            }
            else
            {
                Console.WriteLine("La Computadora ya está apagada.");
            }
        }
    }
}

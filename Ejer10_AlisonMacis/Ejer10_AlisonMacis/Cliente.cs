using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer10_AlisonMacis
{
    internal class Cliente : Persona
    {
        private string telefonoDeContacto;

        public string TelefonoDeContacto
        {
            get { return telefonoDeContacto; }
            set { telefonoDeContacto = value; }
        }

        public override void Mostrar()
        {
            base.Mostrar();
            Console.WriteLine("Telefono de Contacto: " + telefonoDeContacto);
        }
    }
}

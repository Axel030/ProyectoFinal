using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoprogra
{
    class Garaje: Propiedad
    {
        string abierta;
        string boddega;

        public string Abierta
        {
            get
            {
                return abierta;
            }

            set
            {
                abierta = value;
            }
        }

        public string Boddega
        {
            get
            {
                return boddega;
            }

            set
            {
                boddega = value;
            }
        }
    }
}

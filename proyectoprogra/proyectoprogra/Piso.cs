using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoprogra
{
    class Piso: Propiedad
    {
        string vhabitual;
        string cuartos;

        public string Vhabitual
        {
            get
            {
                return vhabitual;
            }

            set
            {
                vhabitual = value;
            }
        }

        public string Cuartos
        {
            get
            {
                return cuartos;
            }

            set
            {
                cuartos = value;
            }
        }
    }
}

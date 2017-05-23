using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoprogra
{
    class Gastos
    {
        string identificacion;
        string nombre;
        string tipreparto;

        public string Identificacion
        {
            get
            {
                return identificacion;
            }

            set
            {
                identificacion = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public string Tipreparto
        {
            get
            {
                return tipreparto;
            }

            set
            {
                tipreparto = value;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoprogra
{
    class Gastos2
    {
        string idgastos;
        string descripcion;
        int importe;
        string zonadereparto;

        public string Idgastos
        {
            get
            {
                return idgastos;
            }

            set
            {
                idgastos = value;
            }
        }

        public string Descripcion
        {
            get
            {
                return descripcion;
            }

            set
            {
                descripcion = value;
            }
        }

        public int Importe
        {
            get
            {
                return importe;
            }

            set
            {
                importe = value;
            }
        }

        public string Zonadereparto
        {
            get
            {
                return zonadereparto;
            }

            set
            {
                zonadereparto = value;
            }
        }
    }
}

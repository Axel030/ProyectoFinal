using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoprogra
{
    class Propiedad
    {
        string tiposdepropiedades;
        string codigoidentificador;
        int metroscuadrados;
        string nit;
        List <string> listaporcentajes;



        public string Tiposdepropiedades
        {
            get
            {
                return tiposdepropiedades;
            }

            set
            {
                tiposdepropiedades = value;
            }
        }

        public string Codigoidentificador
        {
            get
            {
                return codigoidentificador;
            }

            set
            {
                codigoidentificador = value;
            }
        }

        public int Metroscuadrados
        {
            get
            {
                return metroscuadrados;
            }

            set
            {
                metroscuadrados = value;
            }
        }

        public string Nit
        {
            get
            {
                return nit;
            }

            set
            {
                nit = value;
            }
        }

        public string Listaporcentajes
        {
            get
            {
                return listaporcentajes;
            }

            set
            {
                listaporcentajes = value;
            }
        }
    }
}

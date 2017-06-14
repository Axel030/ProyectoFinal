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
        string metroscuadrados;
        string nit;
        List <string> listaporcentajes;
        string listapor;


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

        public string Metroscuadrados
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

        public List<string> Listaporcentajes
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

        public string Listapor
        {
            get
            {
                return listapor;
            }

            set
            {
                listapor = value;
            }
        }
    }
}

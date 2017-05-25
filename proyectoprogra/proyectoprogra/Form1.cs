using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace proyectoprogra
{
    public partial class Form1 : Form
    {
        List<comunidad> listacomunidad = new List<comunidad>();
        List<DatosPropietarios> listadatospropietarios = new List<DatosPropietarios>();
        List<Propiedad> listapropiedad = new List<Propiedad>();
        List<Gastos> listagastos = new List<Gastos>();
        List<Gastos2> listagastos2 = new List<Gastos2>();
        List<Local> listalocal = new List<Local>();
        List<Piso> listapiso = new List<Piso>();
        List<Garaje> listagaraje = new List<Garaje>();

        public void cargando(bool a, bool b)
        {
            if (a == true)
            {
                Assembly _assembly; Stream _imageStream;
                StreamReader _textStreamReader;
                _assembly = Assembly.GetExecutingAssembly();
                _imageStream = _assembly.GetManifestResourceStream("proyectoprogra.comunidad.bmp");
                _textStreamReader = new StreamReader(_assembly.GetManifestResourceStream("proyectoprogra.comunidad.txt"));

                while (_textStreamReader.Peek() > -1)
                {
                    comunidad comutemp = new comunidad();
                    comutemp.Identificacion = _textStreamReader.ReadLine();
                    comutemp.Nombre = _textStreamReader.ReadLine();
                    comutemp.Poblacion = _textStreamReader.ReadLine();
                    listacomunidad.Add(comutemp);
                }
                _textStreamReader.Close();
            }
            if (b == true)
            {
                Assembly _assembly; Stream _imageStream;
                StreamReader _textStreamReader;
                _assembly = Assembly.GetExecutingAssembly();
                _imageStream = _assembly.GetManifestResourceStream("proyectoprogra.Gastos.bmp");
                _textStreamReader = new StreamReader(_assembly.GetManifestResourceStream("proyectoprogra.Gastos.txt"));

                while (_textStreamReader.Peek() > -1)
                {
                    Gastos gastostemp = new Gastos();
                    gastostemp.Identificacion = _textStreamReader.ReadLine();
                    gastostemp.Nombre = _textStreamReader.ReadLine();
                    gastostemp.Tipreparto = _textStreamReader.ReadLine();
                    listagastos.Add(gastostemp);
                }
                _textStreamReader.Close();

            }

        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}

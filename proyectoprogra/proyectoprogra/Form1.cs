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

        public void cargando(bool a, bool b, bool c, bool d, bool de)
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
            if (c == true)
            {
                Assembly _assembly; Stream _imageStream;
                StreamReader _textStreamReader;
                _assembly = Assembly.GetExecutingAssembly();
                _imageStream = _assembly.GetManifestResourceStream("proyectoprogra.DatosPropietarios.bmp");
                _textStreamReader = new StreamReader(_assembly.GetManifestResourceStream("proyectoprogra.DatosPropietarios.txt"));

                while (_textStreamReader.Peek() > -1)
                {
                    DatosPropietarios datospropietariostemp = new DatosPropietarios();
                    datospropietariostemp.Nombre = _textStreamReader.ReadLine();
                    datospropietariostemp.Nit = _textStreamReader.ReadLine();
                    datospropietariostemp.Email =_textStreamReader.ReadLine();
                    
                    listadatospropietarios.Add(datospropietariostemp);
                }
                _textStreamReader.Close();

            }
            if (d == true)
            {
                Assembly _assembly; Stream _imageStream;
                StreamReader _textStreamReader;
                _assembly = Assembly.GetExecutingAssembly();
                _imageStream = _assembly.GetManifestResourceStream("proyectoprogra.Gastos2.bmp");
                _textStreamReader = new StreamReader(_assembly.GetManifestResourceStream("proyectoprogra.Gastos2.txt"));

                while (_textStreamReader.Peek() > -1)
                {

                    Gastos2 gastos2temp = new Gastos2();
                    gastos2temp.Idgastos = _textStreamReader.ReadLine();
                    gastos2temp.Descripcion = _textStreamReader.ReadLine();
                    gastos2temp.Importe = _textStreamReader.ReadLine();
                    gastos2temp.Zonadereparto = _textStreamReader.ReadLine();
                    listagastos2.Add(gastos2temp);
                }
                _textStreamReader.Close();
            }
            if ( de == true)
            {
                Assembly _assembly; Stream _imageStream;
                StreamReader _textStreamReader;
                _assembly = Assembly.GetExecutingAssembly();
                _imageStream = _assembly.GetManifestResourceStream("proyectoprogra.Propiedad.bmp");
                _textStreamReader = new StreamReader(_assembly.GetManifestResourceStream("proyectoprogra.Propiedad.txt"));

                while (_textStreamReader.Peek() > -1)
                { 
                  
                    if (_textStreamReader.ReadLine()== "L")
                    {
                        Localcomercial localcomerciatemp = new Localcomercial();
                        localcomerciatemp.Tiposdepropiedades = _textStreamReader.ReadLine();
                        localcomerciatemp.Codigoidentificador = _textStreamReader.ReadLine();
                        localcomerciatemp.Metroscuadrados = _textStreamReader.ReadLine();
                        localcomerciatemp.Nit = _textStreamReader.ReadLine();
                        localcomerciatemp.Listapor = _textStreamReader.ReadLine();
                        localcomerciatemp.Nombrecomercial = _textStreamReader.ReadLine();
                        localcomerciatemp.Actividad = _textStreamReader.ReadLine();
                    }
                    if (_textStreamReader.ReadLine() == "G")
                    {
                        Garaje garajetemp = new Garaje();
                        garajetemp.Tiposdepropiedades = _textStreamReader.ReadLine();
                        garajetemp.Codigoidentificador = _textStreamReader.ReadLine();
                        garajetemp.Metroscuadrados = _textStreamReader.ReadLine();
                        garajetemp.Nit = _textStreamReader.ReadLine();
                        garajetemp.Listapor = _textStreamReader.ReadLine();
                        garajetemp.Abierta = _textStreamReader.ReadLine();
                        garajetemp.Boddega = _textStreamReader.ReadLine();

                    }
                    if (_textStreamReader.ReadLine() == "P")
                    {
                        Piso pisotemp = new Piso();
                        pisotemp.Tiposdepropiedades = _textStreamReader.ReadLine();
                        pisotemp.Codigoidentificador = _textStreamReader.ReadLine();
                        pisotemp.Metroscuadrados = _textStreamReader.ReadLine();
                        pisotemp.Nit = _textStreamReader.ReadLine();
                        pisotemp.Listapor = _textStreamReader.ReadLine();
                        pisotemp.Vhabitual = _textStreamReader.ReadLine();
                        pisotemp.Cuartos = _textStreamReader.ReadLine();

                    }



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
            Form2 frm = new Form2();
            frm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 frm = new Form4();
            frm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 frm = new Form5();
            frm.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form6 frm = new Form6();
            frm.Show();
            this.Hide();
        }
    }
}

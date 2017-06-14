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
    public partial class Form6 : Form
    {
        List<Propiedad> listapropiedad = new List<Propiedad>();
        public void cargando(bool de)
        {
            if (de == true)
            {
                Assembly _assembly; Stream _imageStream;
                StreamReader _textStreamReader;
                _assembly = Assembly.GetExecutingAssembly();
                _imageStream = _assembly.GetManifestResourceStream("proyectoprogra.Propiedad.bmp");
                _textStreamReader = new StreamReader(_assembly.GetManifestResourceStream("proyectoprogra.Propiedad.txt"));

                while (_textStreamReader.Peek() > -1)
                {
                    if (_textStreamReader.Peek() =! "...") {

                        Propiedad propiedadtemp = new Propiedad();
                        propiedadtemp.Tiposdepropiedades = _textStreamReader.ReadLine();
                        propiedadtemp.Codigoidentificador = _textStreamReader.ReadLine();
                        propiedadtemp.Metroscuadrados = _textStreamReader.ReadLine();
                        propiedadtemp.Nit = _textStreamReader.ReadLine();
                        // propiedadtemp.Listaporcentajes = _textStreamReader.ReadLine();
                        propiedadtemp.Listapor = _textStreamReader.ReadLine();

                        listapropiedad.Add(propiedadtemp);
                    }
                    _textStreamReader.Close();
                }

            }
        }
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            bool de = true;
            cargando(de);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listapropiedad;
            dataGridView1.Refresh();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }
    }
}

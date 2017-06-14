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
    public partial class Form4 : Form
    {
        List<DatosPropietarios> listadatospropietarios = new List<DatosPropietarios>();
        public void cargando(bool c)
        {
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
                    datospropietariostemp.Email = _textStreamReader.ReadLine();

                    listadatospropietarios.Add(datospropietariostemp);
                }
                _textStreamReader.Close();

            }
        }
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool c = true;
            cargando(c);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listadatospropietarios;
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

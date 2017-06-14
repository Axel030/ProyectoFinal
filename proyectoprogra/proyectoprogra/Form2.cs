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
    public partial class Form2 : Form
    {
        List<comunidad> listacomunidad = new List<comunidad>();
        public void cargando(bool a)
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
        }
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool a = true;
            cargando(a);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listacomunidad;
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

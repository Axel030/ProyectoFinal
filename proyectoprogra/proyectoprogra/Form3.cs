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
    public partial class Form3 : Form
    {
        List<Gastos> listagastos = new List<Gastos>();
        public void cargando(bool b)
        {
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
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool b = true;
            cargando(b);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listagastos;
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

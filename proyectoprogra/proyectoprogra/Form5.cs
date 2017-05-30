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
    public partial class Form5 : Form
    {
        List<Gastos2> listagastos2 = new List<Gastos2>();
        public void cargando(bool d)
        {
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
                    gastos2temp.Importe = Convert.ToInt16(_textStreamReader.ReadLine());
                    gastos2temp.Zonadereparto = _textStreamReader.ReadLine();
                    listagastos2.Add(gastos2temp);
                }
                _textStreamReader.Close();
            }
        }
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool d = true;
            cargando(d);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listagastos2;
            dataGridView1.Refresh();
        }
    }
}

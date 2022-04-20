using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogica;

namespace CapaPresentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClaseLogica obj = new ClaseLogica();

            obj.n1 = int.Parse(textBox1.Text);
            obj.n2 = int.Parse(textBox2.Text);

            if (comboBox1.Text == "Suma")
            {
                obj.M_Suma();
                textBox3.Text = obj.Resultado.ToString();
            }
            else if (comboBox1.Text == "Resta")
            {
                obj.M_Resta();
                textBox3.Text = obj.Resultado.ToString();
            }
            else if (comboBox1.Text == "Multiplicacion")
            {
                obj.M_Multi();
                textBox3.Text = obj.Resultado.ToString();
            }
            else if (comboBox1.Text == "Division")
            {
                obj.M_Division();
                textBox3.Text = obj.Resultado.ToString();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiForms
{
    public partial class OperacionesMat : Form
    {
        public OperacionesMat()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Suma")
            {
                textBox3.Text = (int.Parse(textBox1.Text) + int.Parse(textBox2.Text)).ToString();

            }
            else if (comboBox1.Text == "Resta")
            {
                textBox3.Text = (int.Parse(textBox1.Text) - int.Parse(textBox2.Text)).ToString();

            }
            else if (comboBox1.Text == "Multiplicacion")
            {
                textBox3.Text = (int.Parse(textBox1.Text) * int.Parse(textBox2.Text)).ToString();

            }
            else if (comboBox1.Text == "Division")
            {
                textBox3.Text = (int.Parse(textBox1.Text) / int.Parse(textBox2.Text)).ToString();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Bienvenida op = new Bienvenida();
            op.Show();
        }
    }
}

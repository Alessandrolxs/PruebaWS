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
    public partial class CompraVehiculos : Form
    {
        public CompraVehiculos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

            Bienvenida op = new Bienvenida();
            op.Show();
        }

        private void modelo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (marca.Text == "Toyota" && modelo.Text == "Yaris")
            {
                textBox1.Text = 14000.ToString();
            }
            else if (marca.Text == "Toyota" && modelo.Text == "Corolla")
            {
                textBox1.Text = 17000.ToString();
            }
            else
            {
                textBox1.Text = 25000.ToString();
            }
        }
    }
}

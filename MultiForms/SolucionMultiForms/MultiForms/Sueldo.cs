using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiForms
{
    public partial class Sueldo : Form
    {
        public Sueldo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class1 op = new Class1();
            textBox2.Text = Convert.ToString(op.M_SUELDO(EC.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

            Bienvenida op = new Bienvenida();
            op.Show();
        }
    }
}

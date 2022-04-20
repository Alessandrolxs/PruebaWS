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

        private void button1_Click(object sender, EventArgs e)
        {
            Planilla obj = new Planilla();
            sueldo.Text = Convert.ToString(obj.M_Sueldo(sexo.Text));
            afp.Text = Convert.ToString(obj.AFP);
            essalud.Text = Convert.ToString(obj.M_Essalud(ec.Text));
            bonif1.Text = Convert.ToString(obj.M_Bonif1(ec.Text, hijos.Text));
            bonif2.Text = Convert.ToString(obj.M_Bonif2(sexo.Text, hijos.Text, ec.Text));
            neto.Text = Convert.ToString(obj.Neto);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PLANILLA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hijos_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OPERACIONES op= new OPERACIONES();
            Sueldo.Text=Convert.ToString(op.M_SUELDO(Sexo.Text));
            Afp.Text = Convert.ToString(op.M_AFP(EC.Text));
            Essalud.Text = Convert.ToString(op.M_ESSALUD(Hijos.Text));
            Especial.Text = Convert.ToString(op.M_ESPECIAL(Edad.Text));
            TotalAporte.Text = Convert.ToString(op.M_APORT());
            BONI1.Text= Convert.ToString(op.M_BONI1(EC.Text,Edad.Text));
            BONI2.Text = Convert.ToString(op.M_BONI2(EC.Text, Sexo.Text));
            BONI3.Text = Convert.ToString(op.M_BONI3(EC.Text));
            BONI4.Text = Convert.ToString(op.M_BONITOTAL());
            Neto.Text = Convert.ToString(op.M_NETO());
        }

        private void salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nuevo_Click(object sender, EventArgs e)
        {
            Nombre.Text = "";
            Apellidos.Text = "";
            Sexo.Text = "";
            Hijos.Text = "";
            EC.Text = "";
            Edad.Text = "";
            Sueldo.Text = "";
            Neto.Text = "";
            Afp.Text = "";
            Especial.Text = "";
            TotalAporte.Text = "";
            BONI1.Text = "";
            BONI2.Text = "";
            BONI3.Text = "";
            BONI4.Text = "";
            Essalud.Text = "";
            Nombre.Select();
        }

        private void essalud_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Toni_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

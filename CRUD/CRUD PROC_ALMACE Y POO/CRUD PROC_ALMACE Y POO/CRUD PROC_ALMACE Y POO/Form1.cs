using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_PROC_ALMACE_Y_POO
{
    public partial class Form1 : Form
    {
        SP obj = new SP();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            obj.M_Conectar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gridListar.DataSource = obj.M_Listar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            obj.M_Insertar(txtcodigo.Text, txtnombre.Text, txtsexo.Text, int.Parse(txtedad.Text));
            gridListar.DataSource = obj.M_Listar();
            txtcodigo.Clear();
            txtnombre.Clear();
            txtsexo.Clear();
            txtedad.Clear();
            txtcodigo.Select();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            obj.M_Modificar(txtcodigo.Text, txtnombre.Text, txtsexo.Text, int.Parse(txtedad.Text));
            gridListar.DataSource = obj.M_Listar();
            txtcodigo.Clear();
            txtnombre.Clear();
            txtsexo.Clear();
            txtedad.Clear();
            txtcodigo.Select();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            obj.M_Eliminar(txtcodigo.Text);
            gridListar.DataSource = obj.M_Listar();
            txtcodigo.Clear();
            txtcodigo.Select();
        }
    }
}

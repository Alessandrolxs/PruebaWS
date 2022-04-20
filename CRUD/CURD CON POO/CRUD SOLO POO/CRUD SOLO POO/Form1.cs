using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_SOLO_POO
{
    public partial class Form1 : Form
    {
        crudpoo obj = new crudpoo();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            obj.M_Conectar();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            obj.M_Insertar(txtcodigo.Text,txtnombre.Text,txtsexo.Text,int.Parse(txtedad.Text));
            gridListar.DataSource = obj.M_Listar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            gridListar.DataSource = obj.M_Listar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtcodigo.Text = "";
            txtnombre.Text = "";
            txtsexo.Text = "";
            txtedad.Text = "";
            txtcodigo.Select();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            obj.M_Modificar(txtcodigo.Text,txtnombre.Text,txtsexo.Text,int.Parse(txtedad.Text));
            gridListar.DataSource = obj.M_Listar();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            obj.M_Eliminar(txtcodigo.Text);
            gridListar.DataSource = obj.M_Listar();
        }

        private void gridListar_SelectionChanged(object sender, EventArgs e)
        {
            txtcodigo.Text = Convert.ToString(gridListar.Rows[gridListar.CurrentRow.Index].Cells[0].Value);
            txtnombre.Text = Convert.ToString(gridListar.Rows[gridListar.CurrentRow.Index].Cells[1].Value);
            txtsexo.Text = Convert.ToString(gridListar.Rows[gridListar.CurrentRow.Index].Cells[2].Value);
            txtedad.Text = Convert.ToString(gridListar.Rows[gridListar.CurrentRow.Index].Cells[3].Value);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            gridListar.DataSource = obj.M_Buscar(txtbuscar.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void gridListar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXAMEN_CRUD
{
    public partial class Vuelos : Form
    {
        CRUD_VUELOS obj = new CRUD_VUELOS();
        public Vuelos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Seleccion form = new Seleccion();
            form.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtcodigo.Clear();
            txtorigen.Clear();
            txtdestino.Clear();
            txtfecha.Clear();
            txthora.Clear();
            txtenviado.Clear();
            txtbuscar.Clear();
            txtcodigo.Select();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            obj.Registrar(txtcodigo.Text, txtorigen.Text, txtdestino.Text,txtfecha.Text, txthora.Text, txtenviado.Text);
            gridListar.DataSource = obj.Listar();
        }

        private void Vuelos_Load(object sender, EventArgs e)
        {
            gridListar.DataSource = obj.Listar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            obj.Modificar(txtcodigo.Text, txtorigen.Text, txtdestino.Text, txtfecha.Text, txthora.Text, txtenviado.Text);
            gridListar.DataSource = obj.Listar();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            obj.Eliminar(txtcodigo.Text);
            gridListar.DataSource = obj.Listar();
        }

        private void gridListar_SelectionChanged(object sender, EventArgs e)
        {
            txtcodigo.Text = Convert.ToString(gridListar.Rows[gridListar.CurrentRow.Index].Cells[0].Value);
            txtorigen.Text = Convert.ToString(gridListar.Rows[gridListar.CurrentRow.Index].Cells[1].Value);
            txtdestino.Text = Convert.ToString(gridListar.Rows[gridListar.CurrentRow.Index].Cells[2].Value);
            txtfecha.Text = Convert.ToString(gridListar.Rows[gridListar.CurrentRow.Index].Cells[3].Value);
            txthora.Text = Convert.ToString(gridListar.Rows[gridListar.CurrentRow.Index].Cells[4].Value);
            txtenviado.Text = Convert.ToString(gridListar.Rows[gridListar.CurrentRow.Index].Cells[5].Value);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            gridListar.DataSource = obj.Buscar(txtbuscar.Text);
        }
    }
}

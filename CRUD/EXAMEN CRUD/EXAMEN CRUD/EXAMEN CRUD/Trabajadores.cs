using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EXAMEN_CRUD
{
    public partial class Trabajadores : Form
    {
        CRUD_TRABAJ obj = new CRUD_TRABAJ();
        public Trabajadores()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            obj.Registrar(txtcodigo.Text,txtnombre.Text,txtsexo.Text,int.Parse(txtedad.Text),txtseccion.Text);
            gridListar.DataSource = obj.Listar();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            gridListar.DataSource = obj.Listar();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            obj.Modificar(txtcodigo.Text,txtnombre.Text,txtsexo.Text,int.Parse(txtedad.Text),txtseccion.Text);
            gridListar.DataSource = obj.Listar();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            obj.Eliminar(txtcodigo.Text);
            gridListar.DataSource = obj.Listar();
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtcodigo.Clear();
            txtnombre.Clear();
            txtsexo.Clear();
            txtedad.Clear();
            txtseccion.Clear();
            txtcodigo.Select();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gridListar.DataSource = obj.Buscar(txtbuscar.Text);
        }

        private void gridListar_SelectionChanged(object sender, EventArgs e)
        {
            txtcodigo.Text = Convert.ToString(gridListar.Rows[gridListar.CurrentRow.Index].Cells[0].Value);
            txtnombre.Text = Convert.ToString(gridListar.Rows[gridListar.CurrentRow.Index].Cells[1].Value);
            txtsexo.Text = Convert.ToString(gridListar.Rows[gridListar.CurrentRow.Index].Cells[2].Value);
            txtedad.Text = Convert.ToString(gridListar.Rows[gridListar.CurrentRow.Index].Cells[3].Value);
            txtseccion.Text =Convert.ToString(gridListar.Rows[gridListar.CurrentRow.Index].Cells[4].Value);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            Seleccion form = new Seleccion();
            form.Show();
        }

        private void Trabajadores_Load(object sender, EventArgs e)
        {
            gridListar.DataSource = obj.Listar();
        }

        private void gridListar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            gridListar.DataSource = obj.Buscar(txtbuscar.Text);
        }
    }
}

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
    public partial class Usuarios : Form
    {
        CRUD_USERS obj = new CRUD_USERS();
        public Usuarios()
        {
            InitializeComponent();
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            gridListar.DataSource = obj.Listar();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            obj.Registrar(txtid.Text,txtnombre.Text,txtusuario.Text,txtcontraseña.Text);
            gridListar.DataSource = obj.Listar();
            MessageBox.Show("Usuario Creado");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            obj.Registrar(txtid.Text,txtnombre.Text,txtusuario.Text,txtcontraseña.Text);
            gridListar.DataSource = obj.Listar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            obj.Eliminar(txtid.Text);
            gridListar.DataSource = obj.Listar();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            Seleccion form = new Seleccion();
            form.Show();
        }

        private void gridListar_SelectionChanged(object sender, EventArgs e)
        {
            txtid.Text = Convert.ToString(gridListar.Rows[gridListar.CurrentRow.Index].Cells[0].Value);
            txtnombre.Text = Convert.ToString(gridListar.Rows[gridListar.CurrentRow.Index].Cells[1].Value);
            txtusuario.Text = Convert.ToString(gridListar.Rows[gridListar.CurrentRow.Index].Cells[2].Value);
            txtcontraseña.Text = Convert.ToString(gridListar.Rows[gridListar.CurrentRow.Index].Cells[3].Value);
            txtpuesto.Text = Convert.ToString(gridListar.Rows[gridListar.CurrentRow.Index].Cells[4].Value);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtid.Clear();
            txtnombre.Clear();
            txtusuario.Clear();
            txtcontraseña.Clear();
            txtpuesto.Clear();
            txtid.Select();
        }
    }
}

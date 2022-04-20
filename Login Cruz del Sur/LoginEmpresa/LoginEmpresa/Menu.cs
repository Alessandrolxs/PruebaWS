using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginEmpresa
{
    public partial class Menu : Form
    {
        SQLControl obj = new SQLControl();
        

        public Menu()
        {
            InitializeComponent();
            Bitmap img= new Bitmap(Application.StartupPath + @"/img/cruz_sur.jpg");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;

            dataGridView1.DataSource = obj.M_Listar();
        }

        private void registroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            obj.M_Conectar();
            obj.M_Insertar(int.Parse(txtid.Text), int.Parse(txtdni.Text), txtnombre.Text, txtapellido.Text, int.Parse(txtedad.Text), int.Parse(txttelef.Text), txtorigen.Text, txtdestino.Text, txtsalida.Text, int.Parse(txtasiento.Text), int.Parse(txtprecio.Text));
            dataGridView1.DataSource = obj.M_Listar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            obj.M_Conectar();
            obj.M_Modificar(int.Parse(txtid.Text), int.Parse(txtdni.Text), txtnombre.Text, txtapellido.Text, int.Parse(txtedad.Text), int.Parse(txttelef.Text), txtorigen.Text, txtdestino.Text, txtsalida.Text, int.Parse(txtasiento.Text), int.Parse(txtprecio.Text));
            dataGridView1.DataSource = obj.M_Listar();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            obj.M_Conectar();
            obj.M_Eliminar(int.Parse(txtid.Text));
            dataGridView1.DataSource = obj.M_Listar();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtid.Text = "";
            txtdni.Text = "";
            txtnombre.Text = "";
            txtapellido.Text = "";
            txtedad.Text = "";
            txttelef.Text = "";
            txtorigen.Text = "";
            txtdestino.Text = "";
            txtsalida.Text = "";
            txtasiento.Text = "";
            txtprecio.Text = "";

            txtid.Select();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            txtid.Text = Convert.ToString(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value);
            txtdni.Text = Convert.ToString(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value);
            txtnombre.Text = Convert.ToString(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value);
            txtapellido.Text = Convert.ToString(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[3].Value);
            txtedad.Text = Convert.ToString(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[4].Value);
            txttelef.Text = Convert.ToString(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[5].Value);
            txtorigen.Text = Convert.ToString(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[6].Value);
            txtdestino.Text = Convert.ToString(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[7].Value);
            txtsalida.Text = Convert.ToString(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[8].Value);
            txtasiento.Text = Convert.ToString(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[9].Value);
            txtprecio.Text = Convert.ToString(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[10].Value);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = obj.M_Buscar(int.Parse(txtbuscar.Text));
        }
    }
}

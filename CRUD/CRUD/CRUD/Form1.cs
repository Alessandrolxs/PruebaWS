using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnconectar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conectar = new SqlConnection("Data Source=.;Initial Catalog=BaseDatos;Integrated Security=True");
                conectar.Open();
                MessageBox.Show("Conexion Exitosa");
            }
            catch (Exception)
            {

                MessageBox.Show("Error en la Conexion");
            }

        }

        private void btnlistar_Click(object sender, EventArgs e)
        {
            Listar();
        }

        private void Listar()
        {
            SqlConnection conectar = new SqlConnection("Data Source=.;Initial Catalog=BaseDatos;Integrated Security=True");
            conectar.Open();
            SqlDataAdapter dr = new SqlDataAdapter("select * from Personas", conectar);
            DataTable dt = new DataTable();
            dr.Fill(dt);
            gridListar.DataSource = dt;
            conectar.Close();
        }


        private void btninsertar_Click(object sender, EventArgs e)
        {


            SqlConnection conectar = new SqlConnection("Data Source=.;Initial Catalog=BaseDatos;Integrated Security=True");
            conectar.Open();
            SqlCommand com = new SqlCommand("insert into Personas values(" + txtcodigo.Text + ",'" + txtnombre.Text + "','" + txtsexo.Text + "'," + txtedad.Text + ")", conectar);
            com.ExecuteNonQuery();
            conectar.Close();
            Listar();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            SqlConnection conectar = new SqlConnection("Data Source=.;Initial Catalog=BaseDatos;Integrated Security=True");
            conectar.Open();
            SqlCommand com = new SqlCommand("delete from Personas where Cod=" + txtcodigo.Text + "", conectar);
            com.ExecuteNonQuery();
            conectar.Close();
            Listar();
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            SqlConnection conectar = new SqlConnection("Data Source=.;Initial Catalog=BaseDatos;Integrated Security=True");
            conectar.Open();
            SqlCommand com = new SqlCommand("update Personas set Nombre='" + txtnombre.Text + "',Sexo='" + txtsexo.Text + "',Edad=" + txtedad.Text + " where Cod=" + txtcodigo.Text + "", conectar);
            com.ExecuteNonQuery();
            conectar.Close();
            Listar();
        }

        private void txtcodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void gridListar_SelectionChanged(object sender, EventArgs e)
        {
            txtcodigo.Text = Convert.ToString(gridListar.Rows[gridListar.CurrentRow.Index].Cells[0].Value);
            txtnombre.Text = Convert.ToString(gridListar.Rows[gridListar.CurrentRow.Index].Cells[1].Value);
            txtsexo.Text = Convert.ToString(gridListar.Rows[gridListar.CurrentRow.Index].Cells[2].Value);
            txtedad.Text = Convert.ToString(gridListar.Rows[gridListar.CurrentRow.Index].Cells[3].Value);


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

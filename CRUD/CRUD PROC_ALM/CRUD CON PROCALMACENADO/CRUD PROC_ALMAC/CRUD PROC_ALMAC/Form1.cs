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

namespace CRUD_PROC_ALMAC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conectar = new SqlConnection("Data Source =.; Initial Catalog = BaseDatos; Integrated Security = True");
                conectar.Open();
                MessageBox.Show("Conexion Exitosa");
            }
            catch (Exception)
            {

                MessageBox.Show("Error al Conectar");
            }    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conectar = new SqlConnection("Data Source=.;Initial Catalog=BaseDatos;Integrated Security=True");
            conectar.Open();

            SqlCommand com = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            com = new SqlCommand("P_Listar",conectar);
            com.CommandType = CommandType.StoredProcedure;
            da.SelectCommand = com;

            da.Fill(dt);
            gridListar.DataSource = dt;
            conectar.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection conectar = new SqlConnection("Data Source=.;Initial Catalog=BaseDatos;Integrated Security=True");
            conectar.Open();
            SqlCommand com = new SqlCommand("P_Insertar", conectar);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add("@codigo", SqlDbType.Char).Value = txtcodigo.Text;
            com.Parameters.Add("@nombre", SqlDbType.NVarChar).Value = txtnombre.Text;
            com.Parameters.Add("@sexo", SqlDbType.Char).Value = txtsexo.Text;
            com.Parameters.Add("@edad", SqlDbType.Int).Value = txtedad.Text;
            com.ExecuteNonQuery();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection conectar = new SqlConnection("Data Source=.;Initial Catalog=BaseDatos;Integrated Security=True");
            conectar.Open();
            SqlCommand com = new SqlCommand("P_Modificar", conectar);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add("@codigo", SqlDbType.Char).Value = txtcodigo.Text;
            com.Parameters.Add("@nombre", SqlDbType.VarChar).Value = txtnombre.Text;
            com.Parameters.Add("@sexo", SqlDbType.Char).Value = txtsexo.Text;
            com.Parameters.Add("@edad", SqlDbType.Int).Value = txtedad.Text;
            com.ExecuteNonQuery();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection conectar = new SqlConnection("Data Source=.;Initial Catalog=BaseDatos;Integrated Security=True");
            conectar.Open();
            SqlCommand com = new SqlCommand("P_Eliminar", conectar);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add("@codigo", SqlDbType.Char).Value = txtcodigo.Text;
            com.ExecuteNonQuery();
        }
    }
}

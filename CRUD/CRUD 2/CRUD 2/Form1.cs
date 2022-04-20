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
using System.Data.Sql;

namespace CRUD_2
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
                SqlConnection conectar = new SqlConnection("Data Source =.; Initial Catalog = GESTION; Integrated Security = True");
                conectar.Open();
                MessageBox.Show("Conexión Exitosa");
            }
            catch (Exception)
            {

                MessageBox.Show("Error al Conectar");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conectar = new SqlConnection("Data Source =.; Initial Catalog = GESTION; Integrated Security = True");
            conectar.Open();
            SqlDataAdapter dr = new SqlDataAdapter("select * from PRODUCTOS",conectar);
            DataTable dt = new DataTable();
            dr.Fill(dt);
            gridproductos.DataSource = dt;
            conectar.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection conectar = new SqlConnection("Data Source =.; Initial Catalog = GESTION; Integrated Security = True");
            conectar.Open();
            SqlCommand com = new SqlCommand("insert into PRODUCTOS values('"+txtcod_art.Text+"','"+txtseccion.Text+"','"+txtnom_art.Text+"',"+txtprecio.Text+","+dtfecha.Text+","+txtimportado.Text+",'"+txtpais.Text+"')",conectar);
            com.ExecuteNonQuery();
            conectar.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection conectar = new SqlConnection("Data Source =.; Initial Catalog = GESTION; Integrated Security = True");
            conectar.Open();
            SqlCommand com = new SqlCommand("update PRODUCTOS set CÓDIGO DE ARTÍCULO='" + txtcod_art.Text + "',SECCIÓN='" + txtseccion.Text + "',NOMBRE ARTICULO='" + txtnom_art.Text + "',PRECIO=" + txtprecio.Text + ",FECHA=" + dtfecha.Text + ",IMPORTADO=" + txtimportado.Text + ",PAÍS DE ORIGEN='" + txtpais.Text + "'",conectar);
            com.ExecuteNonQuery();
            conectar.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection conectar = new SqlConnection("Data Source =.; Initial Catalog = GESTION; Integrated Security = True");
            conectar.Open();
            SqlCommand com = new SqlCommand("delete from PRODUCTOS where CÓDIGO ARTÍCULO=" + txtcod_art.Text + "", conectar);
            com.ExecuteNonQuery();
            conectar.Close();
        }
    }
}

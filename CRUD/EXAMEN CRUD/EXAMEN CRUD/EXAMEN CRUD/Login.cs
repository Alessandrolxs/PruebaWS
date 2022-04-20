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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conectar = new SqlConnection("Data Source=.;Initial Catalog=BaseDatos;Integrated Security=True");
            conectar.Open();
            string query = "select * from Usuarios where Usuario='" + txtusuario.Text + "'and Contraseña='" + txtcontraseña.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(query,conectar);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                MessageBox.Show("Session Iniciada");
                Seleccion form = new Seleccion();
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Acesso Denegado");
                txtusuario.Clear();
                txtcontraseña.Clear();
                txtusuario.Select();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Bienvenida_Load(object sender, EventArgs e)
        {
            SqlConnection conectar = new SqlConnection("Data Source=.;Initial Catalog=BaseDatos;Integrated Security=True");
            conectar.Open();
        }
    }
}

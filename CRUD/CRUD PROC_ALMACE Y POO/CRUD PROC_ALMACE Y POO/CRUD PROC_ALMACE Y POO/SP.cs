using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace CRUD_PROC_ALMACE_Y_POO
{
    class SP
    {
        public void M_Conectar()
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

        public DataTable M_Listar()
        {
            SqlConnection conectar = new SqlConnection("Data Source=.;Initial Catalog=BaseDatos;Integrated Security=True");
            conectar.Open();

            SqlCommand com = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            com = new SqlCommand("P_Listar", conectar);
            com.CommandType = CommandType.StoredProcedure;
            da.SelectCommand = com;

            da.Fill(dt);
            return dt;
        }

        public void M_Insertar(string codigo, string nombre, string sexo, int edad)
        {
            SqlConnection conectar = new SqlConnection("Data Source=.;Initial Catalog=BaseDatos;Integrated Security=True");
            conectar.Open();
            SqlCommand com = new SqlCommand("P_Insertar", conectar);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add("@codigo", SqlDbType.Char).Value = codigo;
            com.Parameters.Add("@nombre", SqlDbType.VarChar).Value = nombre;
            com.Parameters.Add("@sexo", SqlDbType.Char).Value = sexo;
            com.Parameters.Add("@edad", SqlDbType.Int).Value = edad;
            com.ExecuteNonQuery();
        }

        public void M_Modificar(string codigo, string nombre, string sexo, int edad)
        {
            SqlConnection conectar = new SqlConnection("Data Source=.;Initial Catalog=BaseDatos;Integrated Security=True");
            conectar.Open();
            SqlCommand com = new SqlCommand("P_Modificar", conectar);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add("@codigo", SqlDbType.Char).Value = codigo;
            com.Parameters.Add("@nombre", SqlDbType.VarChar).Value = nombre;
            com.Parameters.Add("@sexo", SqlDbType.Char).Value = sexo;
            com.Parameters.Add("@edad", SqlDbType.Int).Value = edad;
            com.ExecuteNonQuery();
        }

        public void M_Eliminar(string codigo)
        {
            SqlConnection conectar = new SqlConnection("Data Source=.;Initial Catalog=BaseDatos;Integrated Security=True");
            conectar.Open();
            SqlCommand com = new SqlCommand("P_Eliminar", conectar);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add("@codigo", SqlDbType.Char).Value = codigo;
            com.ExecuteNonQuery();
        }
    }
}

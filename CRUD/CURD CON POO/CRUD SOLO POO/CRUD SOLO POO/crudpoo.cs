using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace CRUD_SOLO_POO
{
    class crudpoo
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
            SqlDataAdapter dr = new SqlDataAdapter("select * from Personas", conectar);
            DataTable dt = new DataTable();
            dr.Fill(dt);

            return dt;
        }

        public void M_Insertar(string codigo,string nombre,string sexo,int edad)
        {
            SqlConnection conectar = new SqlConnection("Data Source=.;Initial Catalog=BaseDatos;Integrated Security=True");
            conectar.Open();
            SqlCommand com = new SqlCommand("insert into Personas values('" + codigo + "','" + nombre + "','" + sexo + "'," + edad + ")", conectar);
            com.ExecuteNonQuery();
            conectar.Close();
            
        }

        public void M_Modificar(string codigo, string nombre,string sexo,int edad)
        {
            SqlConnection conectar = new SqlConnection("Data Source=.;Initial Catalog=BaseDatos;Integrated Security=True");
            conectar.Open();
            SqlCommand com = new SqlCommand("update Personas set Nombre='" + nombre + "',Sexo='" + sexo + "',Edad=" + edad + " where Cod=" + codigo + "", conectar);
            com.ExecuteNonQuery();
            conectar.Close();
        }

        public void M_Eliminar(string codigo)
        {
            SqlConnection conectar = new SqlConnection("Data Source=.;Initial Catalog=BaseDatos;Integrated Security=True");
            conectar.Open();
            SqlCommand com = new SqlCommand("delete from Personas where Cod=" + codigo + "", conectar);
            com.ExecuteNonQuery();
            conectar.Close();
        }

        public DataTable M_Buscar(string codigo)
        {
            SqlConnection conectar = new SqlConnection("Data Source=.;Initial Catalog=BaseDatos;Integrated Security=True");
            conectar.Open();
            SqlDataAdapter dr = new SqlDataAdapter("select * from Personas where Cod=" + codigo + "", conectar);
            DataTable dt = new DataTable();
            dr.Fill(dt);

            return dt;
        }

    }
}


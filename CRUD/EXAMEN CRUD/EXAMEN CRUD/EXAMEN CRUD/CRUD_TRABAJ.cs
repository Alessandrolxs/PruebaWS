using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace EXAMEN_CRUD
{
    class CRUD_TRABAJ
    {
        public void CONEXION()
        {
            try
            {
                SqlConnection conectar = new SqlConnection("Data Source=.;Initial Catalog=BaseDatos;Integrated Security=True");
                conectar.Open();
                MessageBox.Show("Se conecto a la Base de Datos");
            }
            catch (Exception)
            {

                MessageBox.Show("No se conecto a la Base de Datos");
            }
        }

        public DataTable Listar()
        {
            SqlConnection conectar = new SqlConnection("Data Source=.;Initial Catalog=BaseDatos;Integrated Security=True");
            conectar.Open();
            SqlDataAdapter dr = new SqlDataAdapter("select * from Trabajadores", conectar);
            DataTable dt = new DataTable();
            dr.Fill(dt);

            return dt;
        }

        public void Registrar(string codigo, string nombre, string sexo, int edad, string seccion)
        {
            SqlConnection conectar = new SqlConnection("Data Source=.;Initial Catalog=BaseDatos;Integrated Security=True");
            conectar.Open();
            SqlCommand com = new SqlCommand("insert into Trabajadores values('" + codigo + "','" + nombre + "','" + sexo + "'," + edad + ",'" + seccion + "')", conectar);
            com.ExecuteNonQuery();
            conectar.Close();
        }

        public void Modificar(string codigo, string nombre, string sexo, int edad, string seccion)
        {
            SqlConnection conectar = new SqlConnection("Data Source=.;Initial Catalog=BaseDatos;Integrated Security=True");
            conectar.Open();
            SqlCommand com = new SqlCommand("update Trabajadores set Nombre='" + nombre + "',Sexo='" + sexo + "',Edad=" + edad + " ,Seccion='"+seccion+"' where Cod=" + codigo + "", conectar);
            com.ExecuteNonQuery();
            conectar.Close();
        }

        public void Eliminar(string codigo)
        {
            SqlConnection conectar = new SqlConnection("Data Source=.;Initial Catalog=BaseDatos;Integrated Security=True");
            conectar.Open();
            SqlCommand com = new SqlCommand("delete from Trabajadores where Cod='" + codigo + "'", conectar);
            com.ExecuteNonQuery();
            conectar.Close();
        }

        public DataTable Buscar(string nombre)
        {
            SqlConnection conectar = new SqlConnection("Data Source=.;Initial Catalog=BaseDatos;Integrated Security=True");
            conectar.Open();
            SqlDataAdapter dr = new SqlDataAdapter("select * from Trabajadores where Nombre like '"+nombre+"'", conectar);
            DataTable dt = new DataTable();
            dr.Fill(dt);

            return dt;
        }
    }
}

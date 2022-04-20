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
    class CRUD_USERS
    {
        public void Conexion()
        {
            SqlConnection conectar = new SqlConnection("Data Source=.;Initial Catalog=BaseDatos;Integrated Security=True");
            conectar.Open();
        }

        public DataTable Listar()
        {
            SqlConnection conectar = new SqlConnection("Data Source=.;Initial Catalog=BaseDatos;Integrated Security=True");
            conectar.Open();
            SqlDataAdapter dr = new SqlDataAdapter("select * from Usuarios", conectar);
            DataTable dt = new DataTable();
            dr.Fill(dt);

            return dt;
        }

        public DataTable Buscar(string nombre)
        {
            SqlConnection conectar = new SqlConnection("Data Source=.;Initial Catalog=BaseDatos;Integrated Security=True");
            conectar.Open();
            SqlDataAdapter dr = new SqlDataAdapter("select * from Usuarios where Nombre like '" + nombre + "'", conectar);
            DataTable dt = new DataTable();
            dr.Fill(dt);

            return dt;
        }

        public void Registrar(string id, string nombre, string usuario, string contraseña)
        {
            SqlConnection conectar = new SqlConnection("Data Source=.;Initial Catalog=BaseDatos;Integrated Security=True");
            conectar.Open();
            SqlCommand com = new SqlCommand("insert into Usuarios values('" + id + "','" + nombre + "','" + usuario + "'," + contraseña + ")", conectar);
            com.ExecuteNonQuery();
            conectar.Close();
        }

        public void Modificar(string id, string nombre, string usuario, string contraseña)
        {
            SqlConnection conectar = new SqlConnection("Data Source=.;Initial Catalog=BaseDatos;Integrated Security=True");
            conectar.Open();
            SqlCommand com = new SqlCommand("update Usuarios set Nombre='" + nombre + "',Usuario=" + usuario + " ,Contraseña='" + contraseña + "' where ID=" + id + "", conectar);
            com.ExecuteNonQuery();
            conectar.Close();
        }

        public void Eliminar(string id)
        {
            SqlConnection conectar = new SqlConnection("Data Source=.;Initial Catalog=BaseDatos;Integrated Security=True");
            conectar.Open();
            SqlCommand com = new SqlCommand("delete from Usuarios where ID='" + id + "'", conectar);
            com.ExecuteNonQuery();
            conectar.Close();
        }
    }
}

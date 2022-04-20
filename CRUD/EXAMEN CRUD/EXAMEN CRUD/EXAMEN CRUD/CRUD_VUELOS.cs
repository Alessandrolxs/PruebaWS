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
    class CRUD_VUELOS
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
            SqlDataAdapter dr = new SqlDataAdapter("select * from Vuelos", conectar);
            DataTable dt = new DataTable();
            dr.Fill(dt);

            return dt;
        }

        public void Registrar(string codigo, string origen, string destino, string fecha, string hora, string enviado)
        {
            SqlConnection conectar = new SqlConnection("Data Source=.;Initial Catalog=BaseDatos;Integrated Security=True");
            conectar.Open();
            SqlCommand com = new SqlCommand("insert into Vuelos values('" + codigo + "','" + origen + "','" + destino + "','" + fecha + "','" + hora + "','"+enviado+"')", conectar);
            com.ExecuteNonQuery();
            conectar.Close();
        }

        public void Modificar(string codigo, string origen, string destino, string fecha, string hora, string enviado)
        {
            SqlConnection conectar = new SqlConnection("Data Source=.;Initial Catalog=BaseDatos;Integrated Security=True");
            conectar.Open();
            SqlCommand com = new SqlCommand("update Vuelos set Origen='" + origen + "',Deestino='" + destino + "',Fecha='" + fecha + "' ,Hora_de_Salida='" + hora + "' where Codigo=" + codigo + "", conectar);
            com.ExecuteNonQuery();
            conectar.Close();
        }

        public void Eliminar(string codigo)
        {
            SqlConnection conectar = new SqlConnection("Data Source=.;Initial Catalog=BaseDatos;Integrated Security=True");
            conectar.Open();
            SqlCommand com = new SqlCommand("delete from Vuelos where Codigo='" + codigo + "'", conectar);
            com.ExecuteNonQuery();
            conectar.Close();
        }

        public DataTable Buscar(string codigo)
        {
            SqlConnection conectar = new SqlConnection("Data Source=.;Initial Catalog=BaseDatos;Integrated Security=True");
            conectar.Open();
            SqlDataAdapter dr = new SqlDataAdapter("select * from Vuelos where Codigo=" + codigo + "", conectar);
            DataTable dt = new DataTable();
            dr.Fill(dt);

            return dt;
        }
    }
}

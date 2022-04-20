using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LoginEmpresa
{
    class SQLControl
    {
        public void M_Conectar()
        {
                SqlConnection conectar = new SqlConnection("Data Source=.;Initial Catalog=ET_CruzdelSur;Integrated Security=True");
                conectar.Open();
        }

        public int Login (string usuario, string contraseña){
            try
            {
                SqlConnection conectar = new SqlConnection("Data Source=.;Initial Catalog=ET_CruzdelSur;Integrated Security=True");
                conectar.Open();

                SqlCommand cmd = new SqlCommand("sp_logueo", conectar);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@contraseña", contraseña);

                SqlDataReader dr = cmd.ExecuteReader();

                if(dr.Read())
                {
                    return dr.GetInt32(0);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            return -1;
        }

        public DataTable M_Listar()
        {
            SqlConnection conectar = new SqlConnection("Data Source=.;Initial Catalog=ET_CruzdelSur;Integrated Security=True");
            conectar.Open();
            SqlDataAdapter dr = new SqlDataAdapter("select * from Clientes", conectar);
            DataTable dt = new DataTable();
            dr.Fill(dt);

            return dt;
        }


        public void M_Insertar(int id, int dni, string nombre, string apellido, int edad, int telefono, string origen, string destino, string salida, int asiento, int precio)
        {
            SqlConnection conectar = new SqlConnection("Data Source=.;Initial Catalog=ET_CruzdelSur;Integrated Security=True");
            conectar.Open();
            SqlCommand com = new SqlCommand("insert into Clientes values("+id+", "+dni+", '"+nombre+"', '"+apellido+"', "+edad+", "+telefono+", '"+origen+"', '"+destino+"', '"+salida+"', "+asiento+", "+precio+")", conectar);
            com.ExecuteNonQuery();
            conectar.Close();

        }

        public void M_Modificar(int id, int dni, string nombre, string apellido, int edad, int telefono, string origen, string destino, string salida, int asiento, int precio)
        {
            SqlConnection conectar = new SqlConnection("Data Source=.;Initial Catalog=ET_CruzdelSur;Integrated Security=True");
            conectar.Open();
            SqlCommand com = new SqlCommand("update Clientes set DNI="+dni+", Nombre='" + nombre + "', Apellido='" + apellido + "', Edad=" + edad + ", Telefono=" + telefono + ", Origen='" + origen + "', Destino='" + destino + "', Hora_Salida='" + salida + "', num_asiento=" + asiento + ", precio=" + precio + " where Id=" + id + " ", conectar);
            com.ExecuteNonQuery();
            conectar.Close();
        }

        public void M_Eliminar(int id)
        {
            SqlConnection conectar = new SqlConnection("Data Source=.;Initial Catalog=ET_CruzdelSur;Integrated Security=True");
            conectar.Open();
            SqlCommand com = new SqlCommand("delete from Clientes where Id=" + id + "", conectar);
            com.ExecuteNonQuery();
            conectar.Close();
        }

        public DataTable M_Buscar(int id)
        {
            SqlConnection conectar = new SqlConnection("Data Source=.;Initial Catalog=ET_CruzdelSur;Integrated Security=True");
            conectar.Open();
            SqlDataAdapter dr = new SqlDataAdapter("select * from Clientes where Id=" + id + "", conectar);
            DataTable dt = new DataTable();
            dr.Fill(dt);

            return dt;
        }
    }
}

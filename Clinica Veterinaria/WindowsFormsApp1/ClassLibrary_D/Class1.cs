using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using ClassLibrary_E;
namespace ClassLibrary_D
{
    public class Class1
    {
        private SqlConnection Conexion = new SqlConnection("Data Source=.;Initial Catalog=clinicavet;Integrated Security=True");

        public SqlConnection AbrirConexion()
        {
            if (Conexion.State == ConnectionState.Closed)
                Conexion.Open();
            return Conexion;
        }

        public SqlConnection CerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
            return Conexion;
        }

        public DataTable D_Login(ClassLibrary_E.Class1 obje)
        {
            SqlCommand cmd = new SqlCommand("sp_Login", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@usuario", obje.usu1);
            cmd.Parameters.AddWithValue("@contraseña", obje.pas1);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dtable1 = new DataTable();
            da.Fill(dtable1);
            return dtable1;
        }

    }
}

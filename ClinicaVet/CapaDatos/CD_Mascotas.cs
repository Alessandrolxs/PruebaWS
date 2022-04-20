using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Mascotas
    {
        private CD_Conexion conexion = new CD_Conexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();
        public DataTable Mostrar()
        {
            //Transact SQL
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "mostrarmas";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }

        public DataTable Buscar(int id)
        {
            //Transact SQL
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "buscarmas";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id", id);
            DataTable dt = new DataTable();
            using (SqlDataAdapter adapter = new SqlDataAdapter(comando))
            {
                adapter.Fill(dt);
            }
            return dt;
        }
    }
}

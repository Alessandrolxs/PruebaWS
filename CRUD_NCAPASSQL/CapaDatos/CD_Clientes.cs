using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Clientes
    {
        private CD_Conexion conexion = new CD_Conexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable Mostrar()
        {
            //Transact SQL
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "mostrar_clientes";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }

        public void Insertar(string nombre, string apellido, int telefono, int num_pedido, int id_pedido)
        {
            //Procedimientos
            //SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "insert_clientes";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Nombre", nombre);
            comando.Parameters.AddWithValue("@Apellido", apellido);
            comando.Parameters.AddWithValue("@Telefono", telefono);
            comando.Parameters.AddWithValue("@Num_pedido", num_pedido);
            comando.Parameters.AddWithValue("@Id_pedido", id_pedido);
            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }

        public void Editar(string nombre, string apellido, int telefono, int num_pedido, int id_pedido, int id)
        {
            //SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "modif_clientes";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Nombre", nombre);
            comando.Parameters.AddWithValue("@Apellido", apellido);
            comando.Parameters.AddWithValue("@Telefono", telefono);
            comando.Parameters.AddWithValue("@Num_pedido", num_pedido);
            comando.Parameters.AddWithValue("@Id_pedido", id_pedido);
            comando.Parameters.AddWithValue("@Id", id);
            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }
        //agregar los botones limpiar, eliminar

        public void Eliminar(int id)
        {
            //SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "elim_Clientes";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Id", id);
            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }

        public DataTable Buscar(int id)
        {
            //Transact SQL
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "buscar_clientes";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Id", id);
            DataTable dt = new DataTable();
            using (SqlDataAdapter adapter = new SqlDataAdapter(comando))
            {
                adapter.Fill(dt);
            }
            return dt;
        }
    }
}

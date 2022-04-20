using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;


namespace CapaDatos
{
    public class CD_Productos
    {
        private CD_Conexion conexion = new CD_Conexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable Mostrar()
        {
            //Transact SQL
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "mostrar_productos";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }
        
        public void Insertar(string nombre, string des, string marca, double precio, int stock)
        {
            //Procedimientos
            //SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "insert_productos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Nombre", nombre);
            comando.Parameters.AddWithValue("@Descripcion", des);
            comando.Parameters.AddWithValue("@Marca", marca);
            comando.Parameters.AddWithValue("@Precio", precio);
            comando.Parameters.AddWithValue("@Stock", stock);
            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }
      
        public void Editar(string nombre, string des, string marca, double precio, int stock, int id)
        {
            //SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "modif_productos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Nombre", nombre);
            comando.Parameters.AddWithValue("@Descripcion", des);
            comando.Parameters.AddWithValue("@Marca", marca);
            comando.Parameters.AddWithValue("@Precio", precio);
            comando.Parameters.AddWithValue("@Stock", stock);
            comando.Parameters.AddWithValue("@Id", id);
            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }
        //agregar los botones limpiar, eliminar

        public void Eliminar(int id)
        {
            //SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "elim_productos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Id", id);
            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }

        public DataTable Buscar(int id)
        {
            //Transact SQL
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "buscar_productos";
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


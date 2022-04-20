using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_Clientes
    {
        private CD_Clientes objetoCD = new CD_Clientes();
        public DataTable MostrarCli()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar();
            return tabla;

        }

        public void InsertarCli(string nombre, string apellido, string telefono, string num_pedido, string id_pedido)
        {
            objetoCD.Insertar(nombre, apellido, Convert.ToInt32(telefono), Convert.ToInt32(num_pedido), Convert.ToInt32(id_pedido));
        }
        public void EditarCli(string nombre, string apellido, string telefono, string num_pedido, string id_pedido, string id)
        {
            objetoCD.Editar(nombre, apellido, Convert.ToInt32(telefono), Convert.ToInt32(num_pedido), Convert.ToInt32(id_pedido), Convert.ToInt32(id));
        }
        public void ElimCli(string id)
        {
            objetoCD.Eliminar(Convert.ToInt32(id));
        }
        public DataTable BuscarCli(string id)
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.Buscar(Convert.ToInt32(id));
            return tabla;
        }

        
    }
}

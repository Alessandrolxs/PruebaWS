using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_Productos
    {
        private CD_Productos objetoCD = new CD_Productos();
        public DataTable MostrarProd()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar();
            return tabla;

        }

        public void InsertarProd(string nombre, string des, string marca, string precio, string stock)
        {
            objetoCD.Insertar(nombre, des, marca, Convert.ToDouble(precio), Convert.ToInt32(stock));
        }
        public void EditarProd(string nombre, string des, string marca, string precio, string stock, string id)
        {
            objetoCD.Editar(nombre, des, marca, Convert.ToDouble(precio), Convert.ToInt32(stock), Convert.ToInt32(id));
        }
        public void ElimProd(string id)
        {
            objetoCD.Eliminar(Convert.ToInt32(id));
        }
        public DataTable BuscarProd(string id)
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.Buscar(Convert.ToInt32(id));
            return tabla;
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class CN_Mascotas
    {
        private CD_Mascotas objetoCD = new CD_Mascotas();
        public DataTable MostrarMas()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar();
            return tabla;

        }
        public DataTable BuscarMas(string id)
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.Buscar(Convert.ToInt32(id));
            return tabla;

        }
    }
}

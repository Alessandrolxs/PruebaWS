using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class CN_Citas
    {
        private CD_Citas objetoCD = new CD_Citas();
        public DataTable MostrarCit()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar();
            return tabla;

        }
        public DataTable BuscarCit(string id)
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.Buscar(Convert.ToInt32(id));
            return tabla;

        }
    }
}

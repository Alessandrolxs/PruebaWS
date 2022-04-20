using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class CN_Tratamientos
    {
        private CD_Tratamientos objetoCD = new CD_Tratamientos();
        public DataTable MostrarTrat()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar();
            return tabla;

        }
        public DataTable BuscarTrat(string id)
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.Buscar(Convert.ToInt32(id));
            return tabla;

        }
    }
}

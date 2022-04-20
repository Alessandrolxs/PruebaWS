using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class CN_Veterinarios
    {
        private CD_Veterinarios objetoCD = new CD_Veterinarios();
        public DataTable MostrarVet()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar();
            return tabla;

        }
        public DataTable BuscarVet(string id)
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.Buscar(Convert.ToInt32(id));
            return tabla;

        }
    }
}

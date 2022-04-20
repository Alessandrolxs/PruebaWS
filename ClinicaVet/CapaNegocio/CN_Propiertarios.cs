using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_Propiertarios
    {
        private CD_Propietarios objetoCD = new CD_Propietarios();
        public DataTable MostrarPro()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar();
            return tabla;

        }

        public void InsertarPro(string nombre, string apellido, string telefono, string direccion, string email)
        {
            objetoCD.Insertar(nombre, apellido, Convert.ToInt32(telefono), direccion, email);
        }
    }
}

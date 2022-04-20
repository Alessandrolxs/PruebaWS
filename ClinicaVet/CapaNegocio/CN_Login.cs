using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CapaNegocio
{
    public class CN_Login
    {
        CapaDatos.CD_Conexion obj = new CapaDatos.CD_Conexion();

        public DataTable N_Login(CapaEntidad.Class1 obje)
        {
            return obj.D_Login(obje);
        }
    }
}


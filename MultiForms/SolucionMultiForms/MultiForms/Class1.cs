using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiForms
{
    class Class1
    {
        public int Sueldo;


        public int M_SUELDO(string EC)
        {
            if (EC == "Soltero")
            {
                Sueldo  = 5000;
            }
            else if (EC == "Casado")
            {
                Sueldo = 4000;
            }
            else if (EC == "Divorciado")
            {
                Sueldo = 3000;
            }
            else if (EC == "Viudo")
            {
                Sueldo = 2000;
            }
            return Sueldo;
        }
    }
}

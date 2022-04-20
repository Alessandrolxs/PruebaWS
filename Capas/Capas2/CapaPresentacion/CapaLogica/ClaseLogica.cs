using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class ClaseLogica
    {
        public int n1, n2, Resultado;

        public void M_Suma()
        {
            Resultado = n1 + n2;
        }
        public void M_Resta()
        {
            Resultado = n1 - n2;
        } 
        public void M_Multi()
        {
            Resultado = n1 * n2;
        }
        public void M_Division()
        {
            Resultado = n1 / n2;
        }
    }
}

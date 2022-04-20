using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class Planilla
    {
        public int Sueldo;
        public double AFP;
        public double Essalud;
        public double Aport;
        public double Bonif1;
        public double Bonif2;
        public double Bonif;
        public double Neto;

        public int M_Sueldo(string sexo)
        {
            if (sexo == "Masculino")
            {
                Sueldo = 5000;
            }
            else
            {
                Sueldo = 3000;
            }
            return Sueldo;
        }
        public double M_AFP(string text)
        {
            AFP = 0.10 * Sueldo;
            return AFP;
        }
        public double M_Essalud(string ec)
        {
            if (ec == "Soltero")
            {
                Essalud = 0.20 * Sueldo;
            }
            else if (ec == "Casado")
            {
                Essalud = 0.10 * Sueldo;
            }
            else if (ec == "Viudo")
            {
                Essalud = 0.5 * Sueldo;
            }
            else
            {
                Essalud = 0.15 * Sueldo;
            }
            return Essalud;
        }
        public double M_Aport()
        {
            Aport = AFP + Essalud;
            return Aport;
        }
        public double M_Bonif1(string ec,string hijos)
        {
            if(ec=="Casado" && Convert.ToInt32(hijos) > 0)
            {
                Bonif1 = 0.20 * Sueldo;
            }
            else
            {
                Bonif1 = Sueldo;
            }
            return Bonif1;
        }
        public double M_Bonif2(string sexo,string hijos,string ec)
        {
            if(Convert.ToInt32(hijos)>0 && sexo=="Femenino" && ec == "Soltero")
            {
                Bonif2 = 0.25 * Sueldo;
            }
            else if (Convert.ToInt32(hijos)>0 && sexo=="Masculino" && ec=="Soltero")
            {
                Bonif2 = 0.10 * Sueldo;
            }
            return Bonif2;
        }
        public double M_Bonif()
        {
            Bonif = Bonif1 + Bonif2;
            return Bonif;
        }
        public double M_Neto()
        {
            Neto = Sueldo - Aport + Bonif;
            return Neto;
        }

    }
}

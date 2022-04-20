using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLANILLA
{
    class OPERACIONES
    {
        public int Sueldo;
        public int Afp;
        public double Essalud;
        public int Especial;
        public double Aport;
        public int BONI1;
        public int BONI2;
        public int BONI3;
        public int BONI4;
        public int TotalBoni;
        public double Neto;


        public int M_SUELDO(string Sexo)
        {

            if (Sexo == "M")
            {
                Sueldo = 5000;
            }
            else
            {
                Sueldo = 3050;
            }
            return Sueldo;
        }
        public int M_AFP(string EC)
        {
            if (EC == "C")
            {
                Afp = 500;
            }
            else if (EC == "S")
            {
                Afp = 400;
            }
            else if (EC == "D")
            {
                Afp = 350;
            }
            else if (EC == "V")
            {
                Afp = 300;
            }
            return Afp;
        }
        public Double M_ESSALUD(string Hijos)
        {
            if (Convert.ToInt32(Hijos)!= 0)
            {
                Essalud = 0.1 * Sueldo;
            }
            else
            {
                Essalud = 0;
            }
            return Essalud;
        }
        public int M_ESPECIAL(string Edad)
        {
            if(Convert.ToInt32(Edad)>=20 && Convert.ToInt32(Edad) <= 25)
            {
                Especial = 500;
            }
            else if(Convert.ToInt32(Edad) >= 30 && Convert.ToInt32(Edad) <= 35)
            {
                Especial = 1000;
            }
            else
            {
                Especial = 0;
            }
            return Especial;
        }
        public double M_APORT()
        {
            Aport = Afp + Essalud + Especial;
            return Aport;
        }
        public int M_BONI1(string EC, string Hijos)
        {
            if(EC=="C" && Convert.ToInt32(Hijos) > 0)
            {
                BONI1 = 1000;
            }
            else
            {   
                BONI1 = 0;
            }
            return BONI1;
        }
        public int M_BONI2(string EC, string Sexo)
        {
            if (EC=="S" && Sexo=="F")
            {
                BONI2 = 1000;
            }
            else
            {
                BONI1 = 0;
            }
            return BONI2;
        }
        public int M_BONI3(string EC)
        {
            if (EC == "S")
            {
                BONI3 = 1000;
            }
            else
            {
                BONI3 = 0;
            }
            return BONI3;
        }
        public int M_BONITOTAL()
        {
            TotalBoni = BONI1 + BONI2 + BONI3;
            return TotalBoni;
        }
        public double M_NETO()
        {
            Neto = Sueldo - TotalBoni + Aport;
            return Neto;
        }
    }
}

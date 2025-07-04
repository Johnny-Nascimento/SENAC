using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjetos.Mao_na_Massa
{
    public class Calculadora
    {
        public double Somar(double n1, double n2)
        {
            return n1 + n2;
        }

        public double Subtrair(double n1, double n2)
        {
            return n1 - n2;
        }

        public double Dividir(double n1, double n2)
        {
            return n1 / n2;
        }

        public double Multiplicar(double n1, double n2)
        {
            return n1 * n2;
        }
    }
}

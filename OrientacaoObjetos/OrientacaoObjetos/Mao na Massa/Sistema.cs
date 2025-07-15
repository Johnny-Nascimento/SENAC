using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjetos.Mao_na_Massa
{
    public class Sistema
    {
        public static void AlteraValores(ref double n1, ref double n2) // , out double n3) // erro **
        {
            n1 += 10;
            n2 /= 3;
            // n3 *= 20; // out parte do principio de que o valor vai ser atribuido no método
        }
    }
}

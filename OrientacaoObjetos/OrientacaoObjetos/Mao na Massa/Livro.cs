using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjetos.Mao_na_Massa
{
    public class Livro
    {
        public string Titulo { get; set; } = string.Empty;
        public string Autor { get; set; } = string.Empty;

        public override string ToString()
        {
            return $"{Titulo} {Autor}";
        }
    }
}

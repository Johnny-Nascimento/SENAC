using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Espeiceneitor.Entidades
{
    public class Missao
    {
        private static int _Index = 1;
        private static List<Missao> _Missoes = new List<Missao>()
        {
            new Missao("Pelé em Marte", 180, DestinoMissao.Marte),
            new Missao("Maradona na lua",18, DestinoMissao.Lua),
                        new Missao("Pelé em Marte", 180, DestinoMissao.Marte),
            new Missao("Maradona na lua",18, DestinoMissao.Lua),
                        new Missao("Pelé em Marte", 180, DestinoMissao.Marte),
            new Missao("Maradona na lua",18, DestinoMissao.Lua),
                        new Missao("Pelé em Marte", 180, DestinoMissao.Marte),
            new Missao("Maradona na lua",18, DestinoMissao.Lua),
                        new Missao("Pelé em Marte", 180, DestinoMissao.Marte),
            new Missao("Maradona na lua",18, DestinoMissao.Lua),
                        new Missao("Pelé em Marte", 180, DestinoMissao.Marte),
            new Missao("Maradona na lua",18, DestinoMissao.Lua),

        };

        public static List<Missao> Missoes
        {
            get
            {
                return new List<Missao>(_Missoes);
            }
        }
        public int Id { get; private set; }
        public string Nome { get; set; }
        public int Duracao { get; set; }
        public string Detalhes { get; set; }
        public StatusMissao StatusMissao { get; set; }
        public DestinoMissao DestinoMissao { get; set; }

        public Missao(string nome, int duracao, DestinoMissao destino = DestinoMissao.Indefinido)
        {
            Id = _Index;
            Nome = nome;
            Duracao = duracao;
            DestinoMissao = destino;

            _Index++;
        }

        public void Create()
        {
            _Missoes.Add(this);
        }
    }
}
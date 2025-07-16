using NASA.DTO;

namespace NASA.ACOES;

public class MissaoEspacial
{
    public List<Astronauta> Astronautas { get; set; }
    public string NomeMissao { get; set; }
    public int DiasDuracao { get; set; }

    private static List<MissaoEspacial> Missoes { get; set; } = new List<MissaoEspacial>();

    public MissaoEspacial(List<Astronauta> astronautas, string nomeMissao, int diasDuracao)
    {
        Astronautas = astronautas;
        NomeMissao = nomeMissao;
        DiasDuracao = diasDuracao;

        Missoes.Add(this);
    }

    public static void AtualizarResultado(string nomeMissao)
    {
        var missao = Missoes.FirstOrDefault(m => m.NomeMissao == nomeMissao);

        if (missao == null)
        {
            Console.WriteLine("Missão não encontrada verifique se o nome foi digitado corretamente.");
            return;
        }

        new ResultadoMissao(missao);
    }
}

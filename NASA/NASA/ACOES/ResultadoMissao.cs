namespace NASA.ACOES;

public class ResultadoMissao
{
    private MissaoEspacial Missao;
    public ResultadoMissao(MissaoEspacial missao)
    {
        Missao = missao;

        FazResultado();
    }

    private void FazResultado()
    {
        Console.Clear();

        Console.WriteLine($"A missão {Missao.NomeMissao}");
        Console.WriteLine($"Com a duração de {Missao.DiasDuracao} dias");
        Console.WriteLine("Com os astronautas: ");
        foreach (var astronauta in Missao.Astronautas)
            Console.WriteLine(astronauta.ToString());

        Console.WriteLine("Não teve problemas, apesar de:");
        Console.WriteLine();

        const int LINHAS_ARQUIVOS = 100;

        Random random = new Random();
        int linhaRandom = random.Next(1, LINHAS_ARQUIVOS);

        List<string> acontecimentosAstronautas = new List<string>();

        foreach (var line in File.ReadLines("AcontecimentosAstronautas.txt"))
        {
            acontecimentosAstronautas.Add(line);
        }

        foreach (var astronauta in Missao.Astronautas)
        {
            Console.WriteLine($"O(A) Astronauta {astronauta.Nome}");

            Console.WriteLine(acontecimentosAstronautas[linhaRandom]);
            linhaRandom = random.Next(1, LINHAS_ARQUIVOS);
        }

        List<string> acontecimentosMissao = new List<string>();

        foreach (var line in File.ReadLines("AcontecimentosMissoes.txt"))
        {
            acontecimentosMissao.Add(line);
        }

        linhaRandom = random.Next(1, LINHAS_ARQUIVOS);

        Console.WriteLine();
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine();

        Console.WriteLine($"A missão {Missao.NomeMissao} foi um sucesso, apesar de um pequeno detalhe:");
        Console.WriteLine();

        Console.WriteLine(acontecimentosMissao[linhaRandom]);

        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine("Aperte qualquer tecla para voltar...");
        Console.ReadKey();
        Console.Clear();
    }
}

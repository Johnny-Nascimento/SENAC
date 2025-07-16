namespace NASA.ACOES;

public class MensagensAleatorias
{
    private const int LINHAS_INICIAL = 0;
    private const int LINHAS_ARQUIVOS = 99;

    private static List<string> AcontecimentosAstronautas = new List<string>();
    private static List<string> AcontecimentosMissao = new List<string>();

    private static void CarregaMensagensAleatorias()
    {
        foreach (var line in File.ReadLines("AcontecimentosAstronautas.txt"))
            AcontecimentosAstronautas.Add(line);

        foreach (var line in File.ReadLines("AcontecimentosMissoes.txt"))
            AcontecimentosMissao.Add(line);
    }

    public static void MostraMensagemAstronautaAleatoria()
    {
        if (AcontecimentosAstronautas.Count == 0 || AcontecimentosMissao.Count == 0)
            CarregaMensagensAleatorias();

        Random random = new Random();
        int linhaAleatoria = random.Next(LINHAS_INICIAL, LINHAS_ARQUIVOS);

        Console.WriteLine(AcontecimentosAstronautas[linhaAleatoria]);
    }

    public static void MostraMensagemMissaoAleatoria()
    {
        if (AcontecimentosAstronautas.Count == 0 || AcontecimentosMissao.Count == 0)
            CarregaMensagensAleatorias();

        Random random = new Random();
        int linhaAleatoria = random.Next(LINHAS_INICIAL, LINHAS_ARQUIVOS);

        Console.WriteLine(AcontecimentosMissao[linhaAleatoria]);
    }
}

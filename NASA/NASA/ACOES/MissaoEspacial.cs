using NASA.DB;
using NASA.DTO;

namespace NASA.ACOES;

public class MissaoEspacial
{
    public List<Astronauta> Astronautas { get; set; }
    public string NomeMissao { get; set; } = string.Empty;
    public int DiasDuracao { get; set; }

    private static List<MissaoEspacial> Missoes { get; set; } = new List<MissaoEspacial>();

    public void CarregaDados(List<Astronauta> astronautas, string nomeMissao, int diasDuracao)
    {
        Astronautas = astronautas;
        NomeMissao = nomeMissao;
        DiasDuracao = diasDuracao;

        Missoes.Add(this);
    }

    public static void MostraQuantidadeDeLancamentos()
    {
        Console.WriteLine($"Ja foram lançadas { Missoes.Count } missões!");
    }

    public static void RealizarLancamento()
    {
        Console.WriteLine("Selecione o numero de identificação dos astronautas separado por: , (ex: 1,2,3,7)");
        Console.WriteLine("Apenas astronautas existentes serão adicionados.");
        var astronautas = AstronautaDB.Astronautas;
        for (int i = 0; i < astronautas.Count; ++i)
        {
            Console.Write(i + 1 + " - ");
            Console.WriteLine(astronautas[i].ToString());
        }

        string[] idsAstronauta = Console.ReadLine()?.Split(",");

        List<Astronauta> astronautasParaLancamento = new List<Astronauta>();

        foreach (var id in idsAstronauta)
        {
            if (int.TryParse(id, out int idInteiro) && --idInteiro < astronautas.Count )
                astronautasParaLancamento.Add(astronautas[idInteiro]);
        }

        Console.WriteLine("Informe o nome da missão");
        string nomeDaMissao = Console.ReadLine();
        if (string.IsNullOrEmpty(nomeDaMissao))
        {
            Console.WriteLine("Nome da missão não pode ser vazio ou nulo.");
            return;
        }

        Console.WriteLine("Informe a duração em dias da missão");
        if (!int.TryParse(Console.ReadLine(), out int duracaoMissao))
        {
            Console.WriteLine("A duraçaõ da missão é inválida, será entendido que a missão ira durar 1 dia.");
            duracaoMissao = 1;
        }

        new MissaoEspacial().CarregaDados(astronautasParaLancamento, nomeDaMissao, duracaoMissao);

        Console.Clear();

        Console.WriteLine($"Contagem regressiva para lançamento da missão {nomeDaMissao}");

        int CONTAGEM_REGRESSIVA_INICIO = 10;

        for (int i = CONTAGEM_REGRESSIVA_INICIO; i >= 0; --i)
        {
            Console.WriteLine(i);
            Thread.Sleep(1000);
        }

        Thread.Sleep(500);

        const string NAVE_DECOLANDO = "       !\r\n       !\r\n       ^\r\n      / \\\r\n     /___\\\r\n    |=   =|\r\n    |     |\r\n    |     |\r\n    |     |\r\n    |     |\r\n    |     |\r\n    |     |\r\n    |     |\r\n    |     |\r\n    |     |\r\n   /|##!##|\\\r\n  / |##!##| \\\r\n /  |##!##|  \\\r\n|  /      \\  |\r\n| /        \\ |\r\n|/          \\|\r\n";
        const string NAVE_VOANDO = "       !\r\n       !\r\n       ^\r\n      / \\\r\n     /___\\\r\n    |=   =|\r\n    |     |\r\n    |     |\r\n    |     |\r\n    |     |\r\n    |     |\r\n    |     |\r\n    |     |\r\n    |     |\r\n    |     |\r\n   /|##!##|\\\r\n  / |##!##| \\\r\n /  |##!##|  \\\r\n|  / ^ | ^ \\  |\r\n| /  ( | )  \\ |\r\n|/   ( | )   \\|\r\n    ((   ))\r\n   ((  :  ))\r\n   ((  :  ))\r\n    ((   ))\r\n     (( ))\r\n      ( )\r\n       .\r\n       .\r\n       .";

        Console.BackgroundColor = ConsoleColor.DarkBlue;
        Console.Clear();
        Console.WriteLine(NAVE_DECOLANDO);
        Thread.Sleep(1000);
        Console.Clear();
        Console.WriteLine(NAVE_VOANDO);

        Console.WriteLine();
        Console.WriteLine("A missão foi lançada com sucesso!");
        Console.WriteLine();
        Console.WriteLine("Aperte qualquer tecla para voltar...");
        Console.ReadKey();
        Console.BackgroundColor = ConsoleColor.Black;
        Console.Clear();
    }

    public static void AtualizarResultado()
    {
        Console.WriteLine("Informe o nome da missão");
        string nomeMissao = Console.ReadLine();

        var missao = Missoes.FirstOrDefault(m => m.NomeMissao == nomeMissao);

        if (missao == null)
        {
            Console.WriteLine("Missão não encontrada verifique se o nome foi digitado corretamente.");
            return;
        }

        ResultadoMissao.MostraResultadoDaMissao(missao);
    }
}

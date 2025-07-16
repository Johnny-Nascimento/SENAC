using static NASA.Menu;
using static System.Net.Mime.MediaTypeNames;

namespace NASA;

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

        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine();

        Console.WriteLine($"A missão {Missao.NomeMissao} foi um sucesso, apesar de um pequeno detalhe:");
        Console.WriteLine();

        Console.WriteLine(acontecimentosMissao[linhaRandom]);

        Console.WriteLine("Aperte qualquer tecla para voltar...");
        Console.ReadKey();
        Console.Clear();
    }
}

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

public class AstronautaDB
{
    public static List<Astronauta> Astronautas { get; } = new List<Astronauta>();

    public AstronautaDB()
    {
        // Dados para facilitar testes
        Astronautas.Add(new Astronauta("Jorge", new DateOnly(2025, 01, 01), "Brasil"));
        Astronautas.Add(new Astronauta("Marcio", new DateOnly(2025, 05, 01), "Alemanha"));
        Astronautas.Add(new Astronauta("Marcos", new DateOnly(2025, 12, 01), "Africa"));
    }

    public static void CadastrarAstronauta()
    {
        Console.WriteLine("Informe o nome do astronauta");
        string nomeAstronauta = Console.ReadLine();

        Console.WriteLine("Informe a data de nascimento do astronauta DD/MM/AA");
        DateOnly dataNascimento = DateOnly.Parse(Console.ReadLine());

        Console.WriteLine("Informe o pais de origem do astronauta");
        string paisOrigem = Console.ReadLine();

        // Validar dados ?
        // Validar dados ?

        Astronautas.Add(new Astronauta(nomeAstronauta, dataNascimento, paisOrigem));

        Console.Clear();
        Console.WriteLine($"Astronauta {nomeAstronauta} cadastrado com sucesso");
    }
}

public class Astronauta
{
    public string Nome { get; set; }
    public DateOnly DataNascimento { get; set; }
    public string PaisOrigem { get; set; }

    public Astronauta(string nome, DateOnly data, string paisOrigem)
    {
        Nome = nome;
        DataNascimento = data;
        PaisOrigem = paisOrigem;
    }

    public override string ToString()
    {
        return $"{Nome} {DataNascimento.ToString()} {PaisOrigem}";
    }
}

public class Menu
{
    public enum OpcoesMenu
    {
        CadastrarAstronauta = 1,
        RealizarLancamento,
        AtualizarResultadoMissao,
        Sair,
        Invalida
    }

    private static void RealizarLancamento()
    {
        const string NAVE_DECOLANDO = "       !\r\n       !\r\n       ^\r\n      / \\\r\n     /___\\\r\n    |=   =|\r\n    |     |\r\n    |     |\r\n    |     |\r\n    |     |\r\n    |     |\r\n    |     |\r\n    |     |\r\n    |     |\r\n    |     |\r\n   /|##!##|\\\r\n  / |##!##| \\\r\n /  |##!##|  \\\r\n|  /      \\  |\r\n| /        \\ |\r\n|/          \\|\r\n";
        const string NAVE_VOANDO    = "       !\r\n       !\r\n       ^\r\n      / \\\r\n     /___\\\r\n    |=   =|\r\n    |     |\r\n    |     |\r\n    |     |\r\n    |     |\r\n    |     |\r\n    |     |\r\n    |     |\r\n    |     |\r\n    |     |\r\n   /|##!##|\\\r\n  / |##!##| \\\r\n /  |##!##|  \\\r\n|  / ^ | ^ \\  |\r\n| /  ( | )  \\ |\r\n|/   ( | )   \\|\r\n    ((   ))\r\n   ((  :  ))\r\n   ((  :  ))\r\n    ((   ))\r\n     (( ))\r\n      ( )\r\n       .\r\n       .\r\n       .";

        Console.WriteLine("Selecione o numero de identificação dos astronautas separado por: , (ex: 1,2,3,7)");
        var astronautas = AstronautaDB.Astronautas;
        for (int i = 0; i < astronautas.Count; ++i)
        {
            Console.Write(i + 1 + " - ");
            Console.WriteLine(astronautas[i].ToString());
        }

        string[] idsAstronauta = Console.ReadLine().Split(",");

        // Validar dados ?
        // Validar dados ?

        List<Astronauta> astronautasParaLancamento = new List<Astronauta>();

        foreach (var id in idsAstronauta)
        {
            int idInteiro = int.Parse(id);

            astronautasParaLancamento.Add(astronautas[idInteiro - 1]);
        }

        Console.WriteLine("Informe o nome da missão");
        string nomeDaMissao = Console.ReadLine();

        Console.WriteLine("Informe a duração em dias da missão");
        int duracaoMissao = int.Parse(Console.ReadLine());

        // Validar dados ?
        // Validar dados ?

        new MissaoEspacial(astronautasParaLancamento, nomeDaMissao, duracaoMissao);

        Console.Clear();

        Console.WriteLine($"Contagem regressiva para lançamento da missão {nomeDaMissao}");

        for (int i = 10; i >= 0; --i)
        {
            Console.WriteLine(i);
            Thread.Sleep(1000);
        }

        Thread.Sleep(500);

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

    private static void MostraOpcoesTexto()
    {
        Console.WriteLine("Menu");
        Console.WriteLine("1 - Cadastrar astronauta");
        Console.WriteLine("2 - Realizar Lançamentos");
        Console.WriteLine("3 - Atualizar resultado da missão");
        Console.WriteLine("4 - Sair");
    }

    public static void Mostrar()
    {
        OpcoesMenu opcaoMenu = 0;

        do
        {
            MostraOpcoesTexto();

            if (int.TryParse(Console.ReadLine(), out int opcaoMenuInteiro))
                opcaoMenu = (OpcoesMenu)opcaoMenuInteiro;
            else
                opcaoMenu = OpcoesMenu.Invalida;

            switch ((OpcoesMenu)opcaoMenu)
            {
                case OpcoesMenu.CadastrarAstronauta:
                    AstronautaDB.CadastrarAstronauta();
                break;

                case OpcoesMenu.RealizarLancamento:
                    RealizarLancamento();
                break;

                case OpcoesMenu.AtualizarResultadoMissao:
                    Console.WriteLine("Informe o nome da missão");
                    MissaoEspacial.AtualizarResultado(Console.ReadLine());
                break;

                case OpcoesMenu.Sair:
                break;

                default:
                    Console.WriteLine("Opção inválida tente novamente.");
                break;
            }
        }
        while (opcaoMenu != OpcoesMenu.Sair);
    }
}

internal class Program
{
    static void Main(string[] args)
    {
        new AstronautaDB();
        Menu.Mostrar();
    }
}

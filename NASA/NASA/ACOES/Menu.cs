using NASA.DB;
using NASA.DTO;

namespace NASA.ACOES;

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
        const string NAVE_VOANDO = "       !\r\n       !\r\n       ^\r\n      / \\\r\n     /___\\\r\n    |=   =|\r\n    |     |\r\n    |     |\r\n    |     |\r\n    |     |\r\n    |     |\r\n    |     |\r\n    |     |\r\n    |     |\r\n    |     |\r\n   /|##!##|\\\r\n  / |##!##| \\\r\n /  |##!##|  \\\r\n|  / ^ | ^ \\  |\r\n| /  ( | )  \\ |\r\n|/   ( | )   \\|\r\n    ((   ))\r\n   ((  :  ))\r\n   ((  :  ))\r\n    ((   ))\r\n     (( ))\r\n      ( )\r\n       .\r\n       .\r\n       .";

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

            switch (opcaoMenu)
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

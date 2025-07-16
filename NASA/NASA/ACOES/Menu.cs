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
                    MissaoEspacial.RealizarLancamento();
                break;

                case OpcoesMenu.AtualizarResultadoMissao:
                    MissaoEspacial.AtualizarResultado();
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

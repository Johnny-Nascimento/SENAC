namespace NASA.ACOES;

public class ResultadoMissao
{
    public static void MostraResultadoDaMissao(MissaoEspacial missao)
    {
        Console.Clear();

        MissaoEspacial.MostraQuantidadeDeLancamentos();
        Console.WriteLine();

        Console.WriteLine($"A missão {missao.NomeMissao}");
        Console.WriteLine($"Com a duração de {missao.DiasDuracao} dias");
        Console.WriteLine("Com os astronautas: ");
        foreach (var astronauta in missao.Astronautas)
            Console.WriteLine(astronauta.ToString());

        Console.WriteLine("Não teve problemas, apesar de:");
        Console.WriteLine();

        foreach (var astronauta in missao.Astronautas)
        {
            Console.WriteLine($"O(A) Astronauta {astronauta.Nome}");

            MensagensAleatorias.MostraMensagemAstronautaAleatoria();
        }

        Console.WriteLine();
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine();

        Console.WriteLine($"A missão {missao.NomeMissao} foi um sucesso, apesar de um pequeno detalhe:");
        Console.WriteLine();

        MensagensAleatorias.MostraMensagemMissaoAleatoria();

        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine();
        Console.WriteLine("Aperte qualquer tecla para voltar...");
        Console.ReadKey();
        Console.Clear();
    }
}

using NASA.DTO;

namespace NASA.DB;

public class AstronautaDB
{
    public static List<Astronauta> Astronautas { get; } = new List<Astronauta>();

    public static void CarregaDadosIniciais()
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
        
        if (string.IsNullOrEmpty(nomeAstronauta))
        {
            Console.WriteLine("Nome não pode ser vazio ou nulo.");
            return;
        }

        Console.WriteLine("Informe a data de nascimento do astronauta DD/MM/AA");
        if (!DateOnly.TryParse(Console.ReadLine(), out DateOnly dataNascimento))
        {
            Console.WriteLine("Data de nascimento inválida, tente novamente.");
            return;
        }

        Console.WriteLine("Informe o pais de origem do astronauta");
        string paisOrigem = Console.ReadLine();

        Astronautas.Add(new Astronauta(nomeAstronauta, dataNascimento, paisOrigem));

        Console.Clear();
        Console.WriteLine($"Astronauta {nomeAstronauta} cadastrado com sucesso");
    }
}

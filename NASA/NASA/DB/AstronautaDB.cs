using NASA.DTO;

namespace NASA.DB;

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

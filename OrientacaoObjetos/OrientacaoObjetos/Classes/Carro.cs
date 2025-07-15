namespace OrientacaoObjetos.Classes;

public class Carro
{
    public string Marca { get; set; } = string.Empty;
    public string Modelo { get; set; } = string.Empty;
    public int  Ano { get; set; }

    public void Acelerar() 
    {
        Console.WriteLine($"{Modelo} Acelerando VRUM! VRUM! VRUM!");
    }

    public void Acelerar(int pedal)
    {
        if (pedal <= 5)
            Console.WriteLine($"{Modelo} Devagar");
        else if (pedal <= 50)
            Acelerar();
        else
            Console.WriteLine($"{Modelo} Rapido");
    }
}

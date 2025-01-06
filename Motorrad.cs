namespace Praxis.Interface;

public class Motorrad : IFahrzeug
{
    public string Hersteller { get; set; }
    public int MaxGeschwindigkeit { get; set; }

    public void Fahren()
    {
        Console.WriteLine($"Der Motorrad fährt!");
    }

    public void Bremsen()
    {
        Console.WriteLine($"Der Motorrad bremst!");
    }
}
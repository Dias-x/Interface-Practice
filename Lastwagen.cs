namespace Praxis.Interface;

public class Lastwagen : IFahrzeug
{
    public string Hersteller { get; set; }
    public int MaxGeschwindigkeit { get; set; }

    public void Fahren()
    {
        Console.WriteLine($"Der Lastwagen fährt!");
    }

    public void Bremsen()
    {
        Console.WriteLine($"Der Lastwagen bremst!");
    }
}
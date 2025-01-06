namespace Praxis.Interface;

public class Auto : IFahrzeug
{
    //EIgenschaften -> müssen die gleiche wie beim Interface übernehmen
    public string Hersteller { get; set; }
    public int MaxGeschwindigkeit { get; set; }

    //Methoden -> müssen die gleiche wie beim Interface übernehmen
    public void Fahren()
    {
        Console.WriteLine($"Das Auto fährt!");
    }

    public void Bremsen()
    {
        Console.WriteLine($"Das Auto bremst!");
    }
}
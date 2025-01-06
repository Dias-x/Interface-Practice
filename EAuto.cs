namespace Praxis.Interface;

public class EAuto : IFahrzeug
{
    public string Hersteller { get; set; }
    public int MaxGeschwindigkeit { get; set; }

    public void Fahren()
    {
        Console.WriteLine($"Das E-Auto fährt!");
    }

    public void Bremsen()
    {
        Console.WriteLine($"Das E-Auto bremst!");
    }
}
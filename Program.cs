using System;
using Praxis.Interface;

class Program
{
    static void Main(string[] args)
    {
        Auto audi = new Auto();
        audi.Hersteller = "Audi";
        audi.MaxGeschwindigkeit = 320;
        
        
        EAuto tesla = new EAuto();
        tesla.Hersteller = "Tesla";
        tesla.MaxGeschwindigkeit = 280;
        
        
        Lastwagen scania = new Lastwagen();
        scania.Hersteller = "Scania";
        scania.MaxGeschwindigkeit = 140;
        
        
        Motorrad yamaha = new Motorrad();
        yamaha.Hersteller = "Yamaha";
        yamaha.MaxGeschwindigkeit = 230;
        
        //"array" die vom Interface gespeichert wird
        IFahrzeug[] fahrzeuge = new IFahrzeug[]
        {
            audi,
            tesla,
            yamaha,
            scania
        };

        /*"foreach" jedes Fahrzeug wird ausgeführt, die im Array abgerufen werden
        und die "Klassen" mit dem Interface geerbt wurden auszuführen. Es können nur die 
        Eigenschaften und Methoden vom Interface abgerufen werden, nicht von einer anderen
        Klasse*/
        foreach (IFahrzeug fahrzeug in fahrzeuge)
        {
            Console.WriteLine(fahrzeug.Hersteller);
            Console.WriteLine(fahrzeug.MaxGeschwindigkeit);
            fahrzeug.Fahren();
            fahrzeug.Bremsen();
        }
    }
}
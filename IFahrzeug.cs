namespace Praxis.Interface;

//Es dürfen nur Methoden, Eigenschaften, Ereignisse und Indexer hinzugefügt werden, kein Code schreiben
public interface IFahrzeug
{
    //Eigenschaften
    string Hersteller { get; set; }
    int MaxGeschwindigkeit { get; set; }
    
    //Methoden
    void Fahren();
    void Bremsen();
}
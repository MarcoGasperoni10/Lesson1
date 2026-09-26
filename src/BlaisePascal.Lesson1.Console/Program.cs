public class Program // Questa è una classe
{
    // Metodo di entrata per esecuzione del codice
    public static void Main()
    {
        Console.WriteLine("Benvenuto nella Easy Class 3E!");

        int costoSpedizione = 5; // dichiarazione + assegnazione
        costoSpedizione = 10; // assegnazione

        int numeroPacchi = 2;

        string tipoConsegna = "Standard"; // dichiarazione + assegnazione

        int costoTotale = costoSpedizione * numeroPacchi;

        Console.WriteLine($"La consegna selezionata è di tipo {tipoConsegna} e il costo totale è di {costoTotale} euro.");
    }
}
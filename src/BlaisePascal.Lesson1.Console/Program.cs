public class Program // Questa è una classe
{
    // Metodo di entrata per esecuzione del codice
    public static void Main()
    {
        Console.WriteLine("Inserisci il nome del cliente:");
        string nomeCliente = Console.ReadLine();

        Console.WriteLine($"Benvenuto {nomeCliente} nella Easy Class 3E!");
        
        Console.WriteLine("Inserisci il tipo di spedizione:");
        string tipoConsegna = Console.ReadLine();

        Console.WriteLine("Inserisci il numero di pacchi acquistati:");
        int numeroPacchi = int.Parse(Console.ReadLine());

        int costoSpedizione = 5;
        costoSpedizione = 10;
        
        int costoTotale = costoSpedizione * numeroPacchi;

        Console.WriteLine($"La consegna selezionata è di tipo {tipoConsegna} e il costo totale è di {costoTotale} euro.");
    }
}
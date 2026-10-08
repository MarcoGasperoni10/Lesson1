using BlaisePascal.Lesson1.Domain;

namespace BlaisePascal.Lesson1.UIConsole
{
    internal class Program // This is a class
    {
        // Entrance function to execute code
        public static void Main()
        {
            try
            {
                Vehicle vehicle1 = new Vehicle("AB123CD", -1, 50, 75);
                Console.WriteLine(vehicle1.LicensePlate);
                Console.WriteLine(vehicle1.OdometerKm);
                Console.WriteLine(vehicle1.DailyRate);
                Console.WriteLine(vehicle1.FuelLevelPercentage);
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
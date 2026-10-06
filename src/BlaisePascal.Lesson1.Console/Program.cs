using BlaisePascal.Lesson1.Domain;

namespace BlaisePascal.Lesson1.UIConsole
{
    internal class Program // This is a class
    {
        // Entrance function to execute code
        public static void Main()
        {
            Enemy enemy = new Enemy();
            enemy.SetHealth(1);
            Console.WriteLine("Enemy Health: " + enemy.Health);
            Console.WriteLine("Enemy is alive: " + enemy.IsAlive());
            enemy.TakeDamage(2);
        }
    }
}
using System;

namespace health
{
    internal static class Program
    {
        private static void Main()
        {
            var rnd = new Random();

            var health = 50;
            var healthPotion = rnd.Next(25, 51);
            var difficulty = 1;

            health = health + healthPotion / difficulty;

            Console.WriteLine(health);
            Console.ReadLine();
        }
    }
}

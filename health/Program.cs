using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace health
{
    class Program
    {
        static void Main()
        {
            //Create new random class
            var rnd = new Random();

            //Initialize variables
            var health = 50;
            var healthPotion = rnd.Next(25, 51);
            var difficulty = 1;

            //Add healthPotion  to health
            health = health + healthPotion / difficulty;

            //Print your new health
            Console.WriteLine(health);
            Console.ReadLine();
        }
    }
}

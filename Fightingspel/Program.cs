using System;
using System.Collections.Generic;

namespace Fightingspel
{
    class Program
    {
        static void Main(string[] args)
        {

            Fighter f1 = new Fighter();

            Fighter f2 = new Fighter();

            while (f1.isAlive && f2.isAlive)
            {
                f1.Attack(f2);
                //Check if f2 is dead
                f2.Update();

                //f2 dont attack if dead
                if (f2.isAlive)
                {
                    f2.Attack(f1);
                    f1.Update();
                }



                Console.WriteLine($"\nFighter {f1.name}: {f1.hp} Health");
                Console.WriteLine($"Fighter {f2.name}: {f2.hp} Health");

                Console.ReadLine();

            }

            string winner = f1.isAlive ? f1.name : f2.name;

            Console.WriteLine($"The winner is {winner}!");




            Console.ReadLine();

        }
    }
}

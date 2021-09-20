using System;

namespace Fightingspel
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Name 1?");
            Fighter f1 = new Fighter(Console.ReadLine());

            Console.WriteLine("Name 2?");
            Fighter f2 = new Fighter(Console.ReadLine());

            while (f1.isAlive && f2.isAlive)
            {
                f1.Attack(f2);
                //Check if f2 is dead
                f2.update();

                //f2 dont attack if dead
                if (f2.isAlive)
                {
                    f2.Attack(f1);
                    f1.update();
                }

                //Linebreak
                Console.WriteLine();

                Console.WriteLine($"Fighter {f1.name}: {f1.hp} Health");
                Console.WriteLine($"Fighter {f2.name}: {f2.hp} Health");

                Console.ReadLine();

            }

            string winner = f1.isAlive ? f1.name : f2.name;

            Console.WriteLine($"The winner is {winner}!");

            Console.ReadLine();

        }
    }
}

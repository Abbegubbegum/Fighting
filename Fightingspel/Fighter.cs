using System;
using System.Collections.Generic;

namespace Fightingspel
{
    public class Fighter
    {
        public string name;

        public int hp = 100;

        public bool isAlive = true;

        private Weapon weapon = new Weapon();

        private List<string> names = new List<string> { "George", "Lucas", "Max", "Balthazar", "Peter", "Cassandra", "Valkyria" };

        Random r = new Random();


        public Fighter()
        {
            name = names[r.Next(names.Count)];
        }

        public void Update()
        {
            if (hp <= 0)
            {
                hp = 0;
                isAlive = false;
                Console.WriteLine($"Fighter {name} is dead!");
            }
        }

        public void Attack(Fighter target)
        {
            weapon.DamageFighter(target);

            Console.WriteLine($"Fighter {name} hit {target.name} for {weapon.damage}");

        }
    }
}
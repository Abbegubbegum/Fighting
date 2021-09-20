using System;

namespace Fightingspel
{
    public class Fighter
    {
        public string name;

        public int hp = 100;

        public bool isAlive = true;

        private Weapon weapon = new Weapon();

        public Fighter(string n)
        {
            name = n;
        }

        public void update()
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
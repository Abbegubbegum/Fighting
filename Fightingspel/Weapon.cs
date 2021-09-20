using System;

namespace Fightingspel
{
    public class Weapon
    {
        public string name = "";

        public int damage = 0;

        private int medianDamage = 10;

        private int critRange = 5;

        private Random r = new Random();



        public void DamageFighter(Fighter target)
        {
            damage = CalculateDamage();

            target.hp -= damage;
        }

        //Calculate the randomness of a hit as a function of median damage and crit range, the median damage can fluctuate from -critrange to critrange
        private int CalculateDamage()
        {
            return medianDamage + r.Next(-critRange, critRange);
        }
    }
}
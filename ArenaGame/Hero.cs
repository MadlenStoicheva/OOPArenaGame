using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public abstract class Hero
    {
        private readonly Random randomPercent = new Random();

        public int HealthPoints { get; set; }
        protected int AttackPoints { get; set; }
        protected int ArmorPoints { get; set; }

        //public bool IsHeroDead {get;set;}

        public virtual double Attacking()
        {
            var attackDamage = AttackPoints * (GetRandomPercent() / 100);
            return attackDamage;
        }

        public virtual double Defending()
        {
            var defendingProtection = ArmorPoints * (GetRandomPercent() / 100);
            return defendingProtection;
        }

        protected double GetRandomPercent()
        {
            return randomPercent.Next(80, 120);
        }

        protected double GetRandomPercentChance()
        {
            return randomPercent.Next(0, 101);
        }
    }
}

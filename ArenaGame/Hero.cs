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

        protected double AttackDamage { get; set; }
        protected double DefendingProtection { get; set; }

        public virtual double Attacking()
        {
            AttackDamage = AttackPoints * (GetRandomPercent() / 100);
            return AttackDamage;
        }

        public virtual double Defending()
        {
            DefendingProtection = ArmorPoints * (GetRandomPercent() / 100);
            return DefendingProtection;
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

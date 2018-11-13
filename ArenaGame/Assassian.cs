using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public class Assassian : Hero
    {
        public const int ChanceToDo300Damage = 30;

        public Assassian()
        {
            HealthPoints = 220;
            AttackPoints = 190;
            ArmorPoints = 180;
        }

        public override double Attacking()
        {
            if (GetRandomPercentChance() <= ChanceToDo300Damage)
            {
                AttackDamage = AttackPoints * (300 / 100);
                return AttackDamage;
            }
            else
            {
                return base.Attacking();
            }
        }

        
    }
}

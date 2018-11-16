using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public class Assassian : Hero
    {
        private const int ChanceToDo300Damage = 30;

        public Assassian()
        {
            HealthPoints = 250;
            AttackPoints = 220;
            ArmorPoints = 200;
        }

        public override double Attacking()
        {
            if (GetRandomPercentChance() <= ChanceToDo300Damage)
            {
                AttackDamage = AttackPoints * 3;
                return AttackDamage;
            }
            else
            {
                return base.Attacking();
            }
        }
    }
}

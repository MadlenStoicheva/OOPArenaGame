using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public class Dwarf:Hero
    {
        private const int ChanceToBlockTheAttack = 15;
        private const int ChanceToDo150Damage = 15;

        public Dwarf()
        {
            HealthPoints = 220;
            AttackPoints = 190;
            ArmorPoints = 180;
        }

        public override double Attacking()
        {
            if (GetRandomPercentChance() <= ChanceToDo150Damage)
            {
                AttackDamage = AttackPoints * 1.5;
                return AttackDamage;
            }
            else
            {
                return base.Attacking();
            }
        }

        public override double Defending()
        {
            if (GetRandomPercentChance() <= ChanceToBlockTheAttack)
            {
                return -1;
            }
            else
            {
                return base.Defending();
            }
        }

    }
}

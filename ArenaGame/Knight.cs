using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public class Knight : Hero
    {
        private const int ChanceToBlockTheAttack = 20;
        private const int ChanceToDo200Damage = 10;

        public Knight()
        {
            HealthPoints = 300;
            AttackPoints = 250;
            ArmorPoints = 200;
        }

        public override double Attacking()
        {
            if (GetRandomPercentChance() <= ChanceToDo200Damage)
            {
                return AttackPoints * 2;
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

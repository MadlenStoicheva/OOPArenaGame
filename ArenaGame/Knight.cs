using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public class Knight : Hero
    {
        public const int ChanceToBlockTheAttack = 20;
        public const int ChanceToDo200Damage = 10;

       // public bool IsBlockingTheAttack { get; set; }

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
                AttackDamage = AttackPoints * 2;
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
               // IsBlockingTheAttack = true;

                DefendingProtection = ArmorPoints;
                return DefendingProtection;
            }
            else
            {
                return base.Defending();
            }
        }

    }
}

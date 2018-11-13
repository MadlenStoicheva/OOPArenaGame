using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public class Monk : Hero
    {
        public const int ChanceToAvoidTheAttack = 30;

        public bool IsBlockingTheAttack { get; set; }

        public Monk()
        {
            HealthPoints = 150;
            AttackPoints = 100;
            ArmorPoints = 90;
        }

        public override double Defending()
        {
            if (GetRandomPercentChance() <= ChanceToAvoidTheAttack)
            {
                IsBlockingTheAttack = true;

                DefendingProtection = ArmorPoints *  100;
                return DefendingProtection;
            }
            else
            {
                return base.Defending();
            }
        }

    }
}

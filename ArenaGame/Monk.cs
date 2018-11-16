using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public class Monk : Hero
    {
        private const int ChanceToAvoidTheAttack = 30;

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
                //DefendingProtection = ArmorPoints * 0.3;
                return 0;
            }
            else
            {
                return base.Defending();
            }
        }

        public bool IsAvoidingTheAttack()
        {
            if (GetRandomPercentChance() <= ChanceToAvoidTheAttack)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

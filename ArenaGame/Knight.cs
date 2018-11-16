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
                DefendingProtection = ArmorPoints * 0.2;
                return DefendingProtection;
            }
            else
            {
                return base.Defending();
            }
        }

        //public bool IsAvoidingTheAttack()
        //{
        //    if (GetRandomPercentChance() <= ChanceToBlockTheAttack)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
    }
}

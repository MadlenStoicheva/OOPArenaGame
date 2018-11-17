using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public class GameEngine
    {
        public string PlayArena(Hero heroOne, Hero heroTwo)
        {
            while (true)
            {
                TurnMechanism(heroOne, heroTwo);

                if (heroTwo.IsHeroDead == true)
                {
                    return WriteIfHeroDead(heroTwo);
                }

                TurnMechanism(heroTwo, heroOne);

                if (heroOne.IsHeroDead == true)
                {
                    return WriteIfHeroDead(heroOne);
                }
            }
        }

        public void TurnMechanism(Hero heroOne, Hero heroTwo)
        {
            var roundOne = AttackDeffendingMechanism(heroOne, heroTwo);
            Console.WriteLine(roundOne);
        }

        public string AttackDeffendingMechanism(Hero heroOne, Hero heroTwo)
        {
            int heroOneAttack = (int)heroOne.Attacking();
            int heroTwoDefending = (int)heroTwo.Defending();

            if (heroTwoDefending == -1)
            {
                return heroTwo.GetType().Name + " prevent the attack!";
            }
            else if (heroTwoDefending <= heroOneAttack)
            {
                heroTwo.HealthPoints -= heroOneAttack - heroTwoDefending;
                if (heroTwo.HealthPoints <= 0)
                {
                    heroTwo.IsHeroDead = true;
                }
                return heroTwo.GetType().Name + " after attack from " + heroOne.GetType().Name + ": " + heroTwo.HealthPoints;
            }
            else
            {
                return heroTwo.GetType().Name + " absorbed the attack!";
            }
        }

        public string WriteIfHeroDead(Hero hero)
        {
            return hero.GetType().Name + " is Dead!";
        }

        //public bool IsHeroDead(Hero hero)
        //{
        //    if (hero.HealthPoints <= 0)
        //    {
        //        return true;
        //    }
        //    return false;
        //}
    }
}
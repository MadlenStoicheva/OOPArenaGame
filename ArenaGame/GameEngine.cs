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
                var roundOne = AttackDeffendingMechanism(heroOne, heroTwo);
                Console.WriteLine(roundOne);

                if (IsHeroDead(heroTwo) == true)
                {
                    return heroTwo.GetType().Name + " is Dead!";
                }

                Console.WriteLine("**********************");

                var roundTwo = AttackDeffendingMechanism(heroTwo, heroOne);
                Console.WriteLine(roundTwo);

                if (IsHeroDead(heroOne) == true)
                {
                    return heroOne.GetType().Name + " is Dead!";
                }

                Console.WriteLine("-----------------------------");
                Console.WriteLine();
            }
        }

        public string AttackDeffendingMechanism(Hero heroOne, Hero heroTwo)
        {
            int result;
            int heroOneAttack = (int)heroOne.Attacking();
            int heroTwoDefending = (int)heroTwo.Defending();

            if (heroTwoDefending == -1)
            {
                return heroTwo.GetType().Name + " avoid the attack!";
            }
            else if (heroTwoDefending <= heroOneAttack)
            {
                result = heroOneAttack - heroTwoDefending;
                heroTwo.HealthPoints = heroTwo.HealthPoints - result;

                return heroTwo.GetType().Name + " after attack from " + heroOne.GetType().Name + ": " + heroTwo.HealthPoints;
            }
            else
            {
                return heroTwo.GetType().Name + " block the attack!";
            }
        }

        public bool IsHeroDead(Hero hero)
        {
            if (hero.HealthPoints <= 0)
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
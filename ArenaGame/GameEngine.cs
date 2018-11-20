using ArenaGame.Library.Engine.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public class GameEngine
    {
        //private GameEngine(IPrint print)
        //{

        //}

        public List<string> PlayArena(Hero heroOne, Hero heroTwo)
        {
            List<string> result = new List<string>();
            while (true)
            {
                result.Add(TurnMechanism(heroOne, heroTwo));

                if (heroTwo.IsHeroDead == true)
                {
                    result.Add(WriteIfHeroDead(heroTwo));
                    return result;
                }

                result.Add(TurnMechanism(heroTwo, heroOne));

                if (heroOne.IsHeroDead == true)
                {
                    result.Add( WriteIfHeroDead(heroOne));
                    return result;
                }
            }
        }

        public string TurnMechanism(Hero heroOne, Hero heroTwo)
        {
            var roundOne = AttackDeffendingMechanism(heroOne, heroTwo);
            //Console.WriteLine(roundOne);
            return roundOne;
        }

        public string AttackDeffendingMechanism(Hero heroOne, Hero heroTwo)
        {
            int heroOneAttack = (int)heroOne.Attack();
            int heroTwoDefending = (int)heroTwo.Defence();

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
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
        public void PlayArena(Hero heroOne, Hero heroTwo, IPrint print)
        {
            while (true)
            {
                print.PrintAttackDeffendingMechanism(AttackDeffendingMechanism(heroOne, heroTwo));

                if (heroTwo.IsHeroDead == true)
                {
                    print.PrintIfHeroIsDead(WriteHeroDead(heroTwo));
                    break;
                }
                
                print.PrintAttackDeffendingMechanism(AttackDeffendingMechanism(heroTwo, heroOne));

                if (heroOne.IsHeroDead == true)
                {
                    print.PrintIfHeroIsDead(WriteHeroDead(heroOne));
                    break;
                }
            }
        }

        public string AttackDeffendingMechanism(Hero heroOne, Hero heroTwo)
        {
            int heroOneAttack = (int)heroOne.Attack();
            int heroTwoDefending = (int)heroTwo.Defence();

            if (heroTwoDefending == -1)
            {
                return heroTwo.GetType().Name + " prevented the attack!";
            }
            else if (heroTwoDefending <= heroOneAttack)
            {
                heroTwo.HealthPoints -= heroOneAttack - heroTwoDefending;
                return heroTwo.GetType().Name + " after attack from " + heroOne.GetType().Name + ": " + heroTwo.HealthPoints;
            }
            else
            {
                return heroTwo.GetType().Name + " absorbed the attack!";
            }
        }

        public string WriteHeroDead(Hero hero)
        {
            return hero.GetType().Name + " is Dead!";
        }
    }
}
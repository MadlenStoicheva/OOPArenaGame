using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public class GameEngine
    {
        public void PlayArena(Hero heroOne, Hero heroTwo)
        {
            int result;
            
            while (true)
            {
                
                int heroOneAttack = (int)heroOne.Attacking();
                int heroOneDefending = (int)heroOne.Defending();

                int heroTwoAttack = (int)heroTwo.Attacking();
                int heroTwoDefending = (int)heroTwo.Defending();

                if (heroTwoDefending <= heroOneAttack)
                {
                    result = heroOneAttack - heroTwoDefending;
                    heroTwo.HealthPoints = heroTwo.HealthPoints - result;
                    Console.WriteLine("Hero two after attack from hero one: " + heroTwo.HealthPoints);
                }
                else
                {
                    Console.WriteLine("Attack was blocked!");
                }
                 

                Console.WriteLine("**********************");

                if (heroTwo.HealthPoints <= 0)
                {
                    Console.WriteLine("Hero two is Dead!");
                    break;

                }
                else
                {
                    if (heroOneDefending <= heroTwoAttack)
                    {
                        result = heroTwoAttack - heroOneDefending;
                        heroOne.HealthPoints = heroOne.HealthPoints - result;
                        Console.WriteLine("Hero one after attack from hero two: " + heroOne.HealthPoints);
                    }
                    else
                    {
                        Console.WriteLine("Attack was blocked!");
                    }

                }

                if (heroOne.HealthPoints <= 0)
                {
                    Console.WriteLine("Hero one is Dead!");
                    break;

                }

                Console.WriteLine("-----------------------------");
                Console.WriteLine();

            }
        }

    }
}

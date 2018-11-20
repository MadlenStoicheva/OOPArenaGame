using ArenaGame.Library.Engine.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.ConsoleApp
{
    public class Print : IPrint
    {
        public void PrintIfHeroIsDead(string message)
        {
            Console.WriteLine(message);
        }

        public void PrintAttackDeffendingMechanism(string message)
        {
            Console.WriteLine(message);
        }
    }
}

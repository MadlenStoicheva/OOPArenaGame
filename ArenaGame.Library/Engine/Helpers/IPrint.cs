using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Library.Engine.Helpers
{
    public interface IPrint
    {
        void PrintAttackDeffendingMechanism(string message);
        void PrintIfHeroIsDead(string message);
    }
}

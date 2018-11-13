using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's play a Game in the Arena!");

            Knight knight = new Knight();
            Assassian assassian = new Assassian();       
            Monk monk = new Monk();
            Warrior warrior = new Warrior();


            GameEngine game = new GameEngine();
            game.PlayArena(knight, assassian);


            //GameEngine gameTwo = new GameEngine();
            //gameTwo.PlayArena(assassian, warrior);


            Console.ReadKey();
        }
    }
}

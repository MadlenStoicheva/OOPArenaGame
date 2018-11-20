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
            Console.WriteLine();

            Knight knight = new Knight();
            Assassian assassian = new Assassian();
            Monk monk = new Monk();
            Warrior warrior = new Warrior();
            Dwarf dwarf = new Dwarf();


            GameEngine game = new GameEngine();
            var result = game.PlayArena(knight, dwarf);

            foreach (var item in result)
            {
                Console.WriteLine(item);

            }


            //GameEngine gameTwo = new GameEngine();
            //gameTwo.PlayArena(assassian, warrior);

            Console.ReadKey();
        }
    }
}

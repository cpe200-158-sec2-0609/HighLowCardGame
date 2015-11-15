using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighLowCardGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Game HiLowCard;
            HiLowCard = new Game();
            HiLowCard.Start();
            while (!HiLowCard.IsEnd())
            {
                HiLowCard.Playing();
                Console.WriteLine(">>>>>Press enter to play next turn...");
                Console.ReadKey();
            }
            Console.ReadKey();
        }
    }
}

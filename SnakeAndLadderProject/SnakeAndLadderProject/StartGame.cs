using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderProject
{
    public class StartGame
    {
        int startPosition = 0;
        public void SinglePlayerGame()
        {
            Random function = new Random();
            int dieCount = function.Next(1, 7);
            Console.WriteLine($"Die count after rolling die : " + dieCount);
        }
    }
}

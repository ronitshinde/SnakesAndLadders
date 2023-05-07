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
            Console.WriteLine($"Start the game at position : " + startPosition);
        }
    }
}

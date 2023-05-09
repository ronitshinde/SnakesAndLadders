using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderProject
{
    public class StartGame
    {

        public void SinglePlayerGame()
        {
            int startPosition = 0;
            int winningPosition = 100;
            int playerPosition = 0;

            while (playerPosition < winningPosition)
            {
                if (playerPosition < 0)
                    playerPosition = 0;
                //else
                Console.WriteLine("PlayerPosition : " + playerPosition);
                Random dieValue = new Random();
                int dieCount = dieValue.Next(1, 7);
                Console.WriteLine($"Die count after rolling die : " + dieCount);
                Random moveNumber = new Random();
                int moveOption = moveNumber.Next(0, 3);
                Console.WriteLine("Move Option : " + moveOption);
                switch (moveOption)
                {
                    case 0:
                        playerPosition = playerPosition;
                        Console.WriteLine($"No play - player stays in same position : " + playerPosition);
                        break;
                    case 1:
                        playerPosition += dieCount;
                        if(playerPosition > winningPosition)
                            playerPosition -= dieCount;
                        Console.WriteLine($"Moves ahead - player moves ahead with the die count value : " + playerPosition);
                        break;
                    case 2:
                        playerPosition -= dieCount;
                        Console.WriteLine($"Moves back - player moves back with the die count value : " + playerPosition);
                        break;
                }
            }
        }
    }
}

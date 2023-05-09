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
            int winningPosition = 100;
            int playerPosition = 0;
            while (playerPosition < winningPosition)
            {
                if (playerPosition < 0)
                    playerPosition = 0;
                Random dieValue = new Random();
                int dieCount = dieValue.Next(1, 7);
                Console.WriteLine($"Die count : " + dieCount);
                Random moveNumber = new Random();
                int moveOption = moveNumber.Next(0, 3);
                switch (moveOption)
                {
                    case 0:
                        Console.WriteLine("Move Option : {0} - No play", moveOption);
                        playerPosition = playerPosition;
                        Console.WriteLine($"Player position : " + playerPosition);
                        break;
                    case 1:
                        Console.WriteLine("Move Option : {0} - Move ahead", moveOption);
                        playerPosition += dieCount;
                        if (playerPosition > winningPosition)
                            playerPosition -= dieCount;
                        Console.WriteLine($"Player position : " + playerPosition);
                        break;
                    case 2:
                        Console.WriteLine("Move Option : {0} - Move back", moveOption);
                        playerPosition -= dieCount;
                        Console.WriteLine($"Player position : " + playerPosition);
                        break;
                }
            }
        }
    }
}

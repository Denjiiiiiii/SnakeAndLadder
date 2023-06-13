using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int playerPosition = 0;
            Random random = new Random();

            while (playerPosition < 100)
            {
                Console.WriteLine("Press enter to roll the dice...");
                Console.ReadLine();

                int dice = random.Next(1, 7);
                playerPosition += dice;

                if (playerPosition > 100)
                {
                    int excess = playerPosition - 100;
                    playerPosition = 100 - excess;
                }

                // Check for snakes and ladders
                switch (playerPosition)
                {
                    case 4:
                        playerPosition = 14;
                        Console.WriteLine("Climbed a ladder! You are now at position 14.");
                        break;
                    case 9:
                        playerPosition = 31;
                        Console.WriteLine("Climbed a ladder! You are now at position 31.");
                        break;
                    case 17:
                        playerPosition = 7;
                        Console.WriteLine("Oops! You landed on a snake. You are now at position 7.");
                        break;
                    case 20:
                        playerPosition = 38;
                        Console.WriteLine("Climbed a ladder! You are now at position 38.");
                        break;
                    case 28:
                        playerPosition = 84;
                        Console.WriteLine("Climbed a ladder! You are now at position 84.");
                        break;
                    case 40:
                        playerPosition = 59;
                        Console.WriteLine("Climbed a ladder! You are now at position 59.");
                        break;
                    case 51:
                        playerPosition = 67;
                        Console.WriteLine("Climbed a ladder! You are now at position 67.");
                        break;
                    case 54:
                        playerPosition = 34;
                        Console.WriteLine("Oops! You landed on a snake. You are now at position 34.");
                        break;
                    case 63:
                        playerPosition = 81;
                        Console.WriteLine("Climbed a ladder! You are now at position 81.");
                        break;
                    case 64:
                        playerPosition = 60;
                        Console.WriteLine("Oops! You landed on a snake. You are now at position 60.");
                        break;
                    case 89:
                        playerPosition = 26;
                        Console.WriteLine("Oops! You landed on a snake. You are now at position 26.");
                        break;
                    case 95:
                        playerPosition = 75;
                        Console.WriteLine("Oops! You landed on a snake. You are now at position 75.");
                        break;
                    case 99:
                        playerPosition = 78;
                        Console.WriteLine("Oops! You landed on a snake. You are now at position 78.");
                        break;
                }

                Console.WriteLine("Current position: " + playerPosition);
                Console.WriteLine();
            }

            Console.WriteLine("Congratulations! You reached the winning spot.");
            Console.ReadLine();
        }
    }
}

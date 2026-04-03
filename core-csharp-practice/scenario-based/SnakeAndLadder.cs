using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.scenarioBased
{
  
    internal class SnakeAndLadder
    {
        //create a board of size 10 x 10
         static int[,] board = new int[10, 10];
         static int[] snakeStart = { 99, 70, 52, 25, 95 };  //snake head
         static int[] snakeEnd = { 54, 55, 42, 2, 72 };     //snake tail
         static int[] ladderStart = { 6, 11, 60, 46, 17 };
         static int[] ladderEnd = { 25, 40, 85, 90, 69 };

         static string[] players;                  //input players from user
         static int[] positions;
         static int playerCount;
         static Random random = new Random();

        public static void Main()
        {
            Console.WriteLine("Snake & Ladder Game");

                Console.WriteLine("1. Start Game");
                Console.WriteLine("2. Exit");
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        SetupGame();
                        PlayGame();
                        break;

                    case "2":
                        Console.WriteLine("Exiting");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }
            }


        // create method for game set up
        public static void SetupGame()
        {
            Console.Write("Enter number of players");
            playerCount = int.Parse(Console.ReadLine());

            if (playerCount < 2 || playerCount > 4)
            {
                Console.WriteLine("Invalid player count");
                return;
            }

           //creates array of strings to store each players name and its position
            players = new string[playerCount];
            positions = new int[playerCount];

            for (int i = 0; i < playerCount; i++)
            {
                Console.Write("Enter Player " + (i + 1) + " name ");
                players[i] = Console.ReadLine();
                positions[i] = 0;
            }

            FillBoard();
        }

        //Method to fill the board
        public static void FillBoard()
        {
            int number = 1;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    board[i, j] = number;
                    number++;
                }
            }
        }

        //Method for play the game
        public static void PlayGame()
        {

            bool gameOn = true;

            while (gameOn)
            {
                for (int turn = 0; turn < playerCount; turn++)
                {
                    Console.WriteLine(players[turn] + " Turn! Press Enter to roll the dice ");
                    Console.ReadLine();

                    int diceValue = RollDice();
                    Console.WriteLine("Dice Rolled: " + diceValue);

                    int oldPosition = positions[turn];
                    int newPosition = MovePlayer(oldPosition, diceValue);

                    newPosition = ApplySnakeOrLadder(newPosition);
                    positions[turn] = newPosition;

                    Console.WriteLine(players[turn]  + oldPosition +  + newPosition);

                    if (CheckWin(newPosition))
                    {
                        Console.WriteLine(players[turn] + " WINS THE GAME!");
                        gameOn = false;
                        break;
                    }
                }
            }
        }

        // Method for dice roll
        public static int RollDice()
        {
            return random.Next(1, 7);
        }

        //Method for moving player
        public static int MovePlayer(int currentPosition, int dice)
        {
            int newPosition = currentPosition + dice;
            return (newPosition > 100) ? currentPosition : newPosition;
        }

        //method if snake or ladder is present
        public static int ApplySnakeOrLadder(int position)
        {
            for (int i = 0; i < snakeStart.Length; i++)
            {
                if (position == snakeStart[i])
                {
                    Console.WriteLine("Snake bite! Slide down to " + snakeEnd[i]);
                    return snakeEnd[i];
                }
            }

            for (int i = 0; i < ladderStart.Length; i++)
            {
                if (position == ladderStart[i])
                {
                    Console.WriteLine("Ladder found! Climb up to " + ladderEnd[i]);
                    return ladderEnd[i];
                }
            }

            return position;
        }

        public static bool CheckWin(int position)
        {
            return position == 100;
        }
    }
}

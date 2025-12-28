using System;

class SnakeLadder
{
    static Random rand = new Random();

    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Snake and Ladder Game!");

        // Input number of players
        Console.Write("Enter number of players (2 to 4): ");
        int numPlayers = int.Parse(Console.ReadLine());

        if (numPlayers < 2 || numPlayers > 4)
        {
            Console.WriteLine("Number of players must be between 2 and 4.");
            return;
        }

        // Player names and positions
        string[] playerNames = new string[numPlayers];
        int[] playerPositions = new int[numPlayers];

        for (int i = 0; i < numPlayers; i++)
        {
            Console.Write("Enter name for Player " + (i + 1) + ": ");
            playerNames[i] = Console.ReadLine();
            playerPositions[i] = 0;
        }

        // Snakes (start -> end)
        int[,] snakes =
        {
            {16, 6},
            {47, 26},
            {49, 11},
            {56, 53},
            {62, 19},
            {64, 60},
            {87, 24},
            {93, 73},
            {95, 75},
            {98, 78}
        };

        // Ladders (start => end)
        int[,] ladders =
        {
            {1, 38},
            {4, 14},
            {9, 31},
            {21, 42},
            {28, 84},
            {36, 44},
            {51, 67},
            {71, 91},
            {80, 100}
        };

        bool gameRunning = true;

        // Game loop
        while (gameRunning)
        {
            for (int i = 0; i < numPlayers; i++)
            {
                Console.WriteLine("\n" + playerNames[i] + "'s turn");

                int diceValue = RollDice();
                Console.WriteLine("Dice rolled: " + diceValue);

                int oldPosition = playerPositions[i];
                int newPosition = MovePlayer(oldPosition, diceValue);

                if (newPosition == oldPosition)
                {
                    Console.WriteLine("Move skipped (dice exceeded 100)");
                    continue;
                }

                newPosition = ApplySnakeOrLadder(newPosition, snakes, ladders);

                playerPositions[i] = newPosition;
                Console.WriteLine("Position: " + oldPosition + " → " + newPosition);

                if (CheckWin(newPosition))
                {
                    Console.WriteLine( + playerNames[i] + " WINS THE GAME!");
                    gameRunning = false;
                    break;
                }
            }
        }

        Console.WriteLine("\nGame Over");
    }

    // Roll Dice
    static int RollDice()
    {
        return rand.Next(1, 7);
    }

    // Move Player
    static int MovePlayer(int currentPosition, int diceValue)
    {
        int newPosition = currentPosition + diceValue;

        if (newPosition > 100)
        {
            return currentPosition;
        }

        return newPosition;
    }

    // Apply Snake or Ladder
    static int ApplySnakeOrLadder(int position, int[,] snakes, int[,] ladders)
    {
        for (int i = 0; i < snakes.GetLength(0); i++)
        {
            if (position == snakes[i, 0])
            {
                Console.WriteLine("Oh no! Snake bite ");
                return snakes[i, 1];
            }
        }

        for (int i = 0; i < ladders.GetLength(0); i++)
        {
            if (position == ladders[i, 0])
            {
                Console.WriteLine("Yay! Ladder climb ");
                return ladders[i, 1];
            }
        }

        return position;
    }

    // Check Win
    static bool CheckWin(int position)
    {
        return position == 100;
    }
}

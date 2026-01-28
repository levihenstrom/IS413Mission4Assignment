// welcome the user to the game

using Mission4Assignment;

GameTools gt = new GameTools();

Console.WriteLine("Welcome to Tic Tac Toe Game!");
Console.WriteLine("Please press enter to play.");
Console.ReadLine(); // actually waits

bool playGame = true;

//Program Loop
while (playGame)
{
    string[] gameBoard = new string[9];

    for (int i = 0; i < gameBoard.Length; i++)
    {
        gameBoard[i] = " ";
    }

    string openSpaces = "012345678";
    int outcome = 0; // 0=none, 1=p1 win, 2=p2 win, 3=tie

    int currentPlayer = 1; // 1 or 2
    bool gameOver = false;
    
    Console.WriteLine("Player 1 is 'O', Player 2 is 'X'");
    //Game Loop
    while (!gameOver)
    {
        gt.PrintBoard(gameBoard);

        // Input Loop
        bool inputBad = true;
        while (inputBad)
        {
            Console.Write($"Player {currentPlayer}, Enter your choice (1-9): ");
            string? input = Console.ReadLine();

            if (!int.TryParse(input, out int move))
            {
                Console.WriteLine("Invalid input. Enter a number.");
                continue;
            }

            move = move - 1;
            if (move < 0 || move > 8)
            {
                Console.WriteLine("Out of range. Enter 0-8.");
                continue;
            }

            if (!openSpaces.Contains(move.ToString()))
            {
                Console.WriteLine("That spot is taken.");
                continue;
            }

            // place mark
            string mark = (currentPlayer == 1) ? "O" : "X";
            gameBoard[move] = mark;

            // remove space from available list
            openSpaces = openSpaces.Replace(move.ToString(), "");

            inputBad = false;
        }

        // Check win/tie
        outcome = gt.CheckWinner(gameBoard);

        if (outcome != 0)
        {
            gameOver = true;
        }
        else
        {
            // Switch turns only if game continues
            currentPlayer = (currentPlayer == 1) ? 2 : 1;
        }
    }

    // Show final board + message
    gt.PrintBoard(gameBoard);

    if (outcome == 1 || outcome == 2)
    {
        Console.WriteLine($"Player {outcome} wins!!!");
    }
    else if (outcome == 3)
    {
        Console.WriteLine("Tie game.");
    }
    else
    {
        Console.WriteLine("Sorry, an error occurred.");
    }

    //Ask to play again
    Console.Write("Do you want to play again? (y/n): ");
    string? again = Console.ReadLine();
    playGame = (again != null && again.ToLower() == "y");
}
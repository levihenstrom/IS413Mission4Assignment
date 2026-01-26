// welcome the user to the name 

using Mission4Assignment;

GameTools gt = new GameTools();

Console.WriteLine("Welcome to Tic Tac Toe Game!: ");
Console.WriteLine("Please press enter to play");

bool playGame = true;


while (playGame)
{
    string[] gameBoard = new string[9];
    string openSpaces = "012345678";
    
    bool gameOver = false;
    while (!gameOver)
    {
        gt.PrintBoard(gameBoard);
        Console.Write("Player 1, Enter you choice: ");
        char player1 = Convert.ToChar(Console.ReadLine());
        
        if (player1 == )
    }
}
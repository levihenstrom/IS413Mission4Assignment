namespace Mission4Assignment;

public class GameTools
{
    public void PrintBoard(string[] board)
    {
        Console.WriteLine(board);
        Console.WriteLine("Board received!");
    }
    
    public int CheckWinner(string[] board)
    {
        bool winnerDetermined = false;
        int outcome = 0;
        
        while (!winnerDetermined)
        {   
            //Vertical
            for (int i = 0; i < 3; i++)
            {
                if (board[i] == "o" && board[i + 3] == "o" && board[i + 6] == "o")
                {
                    Console.WriteLine("Player One wins!");
                    outcome = 1;
                    winnerDetermined = true;
                }
                else if (board[i] == "x" && board[i + 3] == "x" && board[i + 6] == "x")
                {
                    Console.WriteLine("Player Two wins!");
                    outcome = 2;
                    winnerDetermined = true;
                }
                else
                {
                    Console.WriteLine("Draw");
                    outcome = 3;
                    winnerDetermined = true;
                }
            }
            
            //Horizontal
            for (int i = 0; i <= 6; i += 3)
            {
                if (board[i] == "o" && board[i + 1] == "o" && board[i + 2] == "o")
                {
                    Console.WriteLine("Player One wins!");
                    outcome = 1;
                    winnerDetermined = true;
                }
                else if (board[i] == "x" && board[i + 1] == "x" && board[i + 2] == "x")
                {
                    Console.WriteLine("Player Two wins!");
                    outcome = 2;
                    winnerDetermined = true;
                }
                else
                {
                    Console.WriteLine("Draw");
                    outcome = 3;
                    winnerDetermined = true;
                }
            }
            
            //Diagonal
            if (board[0] == "o" && board[4] == "o" && board[8] == "o")
            {
                Console.WriteLine("Player One wins!");
                outcome = 1;
                winnerDetermined = true;
            }
            else
            {
                Console.WriteLine("Draw");
                outcome = 3;
                winnerDetermined = true;
            }

            if (board[0] == "x" && board[4] == "x" && board[8] == "x")
            {
                Console.WriteLine("Player Two wins!");
                outcome = 2;
                winnerDetermined = true;
            }
            else
            {
                Console.WriteLine("Draw");
                outcome = 3;
                winnerDetermined = true;
            }

            if (board[2] == "o" && board[4] == "o" && board[6] == "o")
            {
                Console.WriteLine("Player One wins!");
                outcome = 1;
                winnerDetermined = true;
            }
            else
            {
                Console.WriteLine("Draw");
                outcome = 3;
                winnerDetermined = true;
            }

            if (board[2] == "x" && board[4] == "x" && board[6] == "x")
            {
                Console.WriteLine("Player Two wins!");
                outcome = 2;
                winnerDetermined = true;
            }
            else
            {
                Console.WriteLine("Draw");
                outcome = 3;
                winnerDetermined = true;
            }
        }
        
        return outcome;
    }
}
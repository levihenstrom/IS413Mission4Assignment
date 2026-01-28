namespace Mission4Assignment;

public class GameTools
    {
        public void PrintBoard(string[] board)
        {
            Console.WriteLine();
            Console.WriteLine($"{board[0]} | {board[1]} | {board[2]}");
            Console.WriteLine("--+---+--");
            Console.WriteLine($"{board[3]} | {board[4]} | {board[5]}");
            Console.WriteLine("--+---+--");
            Console.WriteLine($"{board[6]} | {board[7]} | {board[8]}");
            Console.WriteLine();
        }
        
        // 0 = no winner yet
        // 1 = Player One wins ("o")
        // 2 = Player Two wins ("x")
        // 3 = draw (board full, no winner)
        public int CheckWinner(string[] board)
        {
            // All winning combinations (rows, cols, diagonals)
            int[][] wins =
            {
                new[] {0, 1, 2},
                new[] {3, 4, 5},
                new[] {6, 7, 8},
                new[] {0, 3, 6},
                new[] {1, 4, 7},
                new[] {2, 5, 8},
                new[] {0, 4, 8},
                new[] {2, 4, 6}
            };

            // Check if anyone has won
            foreach (int[] line in wins)
            {
                string a = board[line[0]];
                string b = board[line[1]];
                string c = board[line[2]];

                // If a,b,c are the same and they're either "o" or "x", it's a win.
                if (a == b && b == c)
                {
                    if (a == "O") return 1;
                    if (a == "X") return 2;
                }
            }

            // No winner: check if board is full (draw)
            bool boardFull = true;
            
            for (int i = 0; i < board.Length; i++)
            {
                if (board[i] != "x" && board[i] != "o")
                {
                    boardFull = false;
                    break;
                }
            }

            if (boardFull) return 3;

            // No winner and board not full => game continues
            return 0;
        }
    }
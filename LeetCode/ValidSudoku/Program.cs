namespace ValidSudoku
{
    public class SolutionValidSudoku
    {
        public static bool IsValidSudoku(char[][] board)
        {
            for (int i = 0; i < 9; i++)
            {
                HashSet<char> horizon = new HashSet<char>();
                HashSet<char> vertical = new HashSet<char>();
                HashSet<char> block = new HashSet<char>();
                for (int j = 0; j < 9; j++)
                {
                    if (board[j][i] != '.' && !horizon.Add(board[j][i]))
                        return false;
                    if (board[i][j] != '.' && !vertical.Add(board[i][j]))
                        return false;

                    int row = 3 * (i / 3) + j / 3;
                    int col = 3 * (i % 3) + j % 3;
                    if (board[row][col] != '.' && !block.Add(board[row][col]))
                        return false;
                }
            }
            return true;
        }

        public static void Main(string[] args)
        {
            char[][] board = new char[][]
            {
            new char[] {'.','.','.','.','5','.','.','1','.'},
            new char[] {'.','4','.','3','.','.','.','.','.'},
            new char[] {'.','.','.','.','.','3','.','.','1'},
            new char[] {'8','.','.','.','.','.','.','2','.'},
            new char[] {'.','.','2','.','7','.','.','.','.'},
            new char[] {'.','1','5','.','.','.','.','.','.'},
            new char[] {'.','.','.','.','.','2','.','.','.'},
            new char[] {'.','2','.','9','.','.','.','.','.'},
            new char[] {'.','.','4','.','.','.','.','.','.'}
        };
            var result = IsValidSudoku(board);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}

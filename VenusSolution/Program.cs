public enum TicTacToeState
{
    InProgress,
    Win,
    Tie
}

public enum TicTacToePlayer
{
    X,
    O
}

public class TicTacToe
{
    private readonly TicTacToePlayer[,] _board = new TicTacToePlayer[3, 3];
    private TicTacToePlayer _currentPlayer = TicTacToePlayer.X;

    public TicTacToeState State { get; private set; } = TicTacToeState.InProgress;

    public TicTacToePlayer CurrentPlayer => _currentPlayer;

    public void MakeMove(int row, int col)
    {
        if (row < 0 || row > 2 || col < 0 || col > 2)
            throw new ArgumentException("Invalid move detected");

        if (_board[row, col] != 0)
            throw new ArgumentException("Invalid move detected");

        _board[row, col] = _currentPlayer;

        if (CheckWin())
        {
            State = TicTacToeState.Win;
            return;
        }

        if (CheckTie())
        {
            State = TicTacToeState.Tie;
            return;
        }

        _currentPlayer = _currentPlayer == TicTacToePlayer.X ? TicTacToePlayer.O : TicTacToePlayer.X;
    }

    private bool CheckWin()
    {
        // Checking rows
        for (int row = 0; row < 3; row++)
        {
            if (_board[row, 0] != 0 && _board[row, 0] == _board[row, 1] && _board[row, 1] == _board[row, 2])
                return true;
        }

        // Checking columns
        for (int col = 0; col < 3; col++)
        {
            if (_board[0, col] != 0 && _board[0, col] == _board[1, col] && _board[1, col] == _board[2, col])
                return true;
        }

        // Checking diagonals
        if (_board[1, 1] != 0 &&
            ((_board[0, 0] == _board[1, 1] && _board[1, 1] == _board[2, 2]) ||
             (_board[0, 2] == _board[1, 1] && _board[1, 1] == _board[2, 0])))
            return true;

        return false;
    }

    private bool CheckTie()
    {
        for (int row = 0; row < 3; row++)
        {
            for (int col = 0; col < 3; col++)
            {
                if (_board[row, col] == 0)
                    return false;
            }
        }

        return true;
    }
}

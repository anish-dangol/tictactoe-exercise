# tictactoe-exercise
Tic Tac Toe Exercise using Csharp, .Net and Xunit

Requirement:
1.  There should be no user interface.
--> THere is no UI.

2. The code should be unit tested.
--> Unit tested using Xunit .

3. Track all player moves on the board.
--> The player moves are tracked on the _board array. When a player makes a move by calling the MakeMove method, the corresponding position on the board is updated with the current player's symbol (X or O).

4. Do not allow invalid moves.
--> MakeMove method checks for invalid moves before updating the board with a player's move.

5. Track the win state of the game (in progress, win, which player won, etc).
--> MakeMove method updates the state of the game based on whether a win or tie has occurred by calling CheckWin and CheckTie methods.

6. Player X always goes first.
--> The initial value of _currentPlayer is set to TicTacToePlayer.X.

7. Write the code in such a way that an independent module could use it.
--> The TicTacToe class can be used by other modules or components.



Assumptions:

a. The game is played between two players represented by 'X' and 'O'.

b. The game is played on a 3x3 grid.

c. The Tic Tac Toe game implementation has a 'MakeMove' method; it takes two arguments - the row and column where the player wants to place their marker.

d. The Tic Tac Toe game implementation has a 'CurrentPlayer' property; it keeps track of the current player who is supposed to make a move.

e. The Tic Tac Toe game implementation has a 'State' property; it keeps track of the current state of the game, which can be 'InProgress', 'Win', or 'Draw'.

f. The code uses the Xunit testing framework.

g. The code defines several unit tests to test different aspects of the Tic Tac Toe game implementation.

Time Spent:
3 Hour 56 minutes

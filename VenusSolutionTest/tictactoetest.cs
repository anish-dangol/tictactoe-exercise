using Xunit;
using System;
using VenusSolutionTest;

namespace VenusSolutionTest
{
    public class TicTacToeTests
    {

        //Testing: The Game always starts with player X
        [Fact]
        public void TestXAlwaysGoesFirst()
        {
            TicTacToe game = new TicTacToe();
            Assert.Equal(TicTacToePlayer.X, game.CurrentPlayer);
        }

        // Testing: when a player makes a move, the current player changes to the other player (either from X to O or O to X)
        [Fact]
        public void TestMakeMove()
        {
            TicTacToe game = new TicTacToe();
            game.MakeMove(0, 0);
            Assert.Equal(TicTacToePlayer.O, game.CurrentPlayer);
        }

        // Testing: the game starts in the InProgress state with player X as the current player
        [Fact]
        public void TestInitialState()
        {
            TicTacToe game = new TicTacToe();
            Assert.Equal(TicTacToeState.InProgress, game.State);
            Assert.Equal(TicTacToePlayer.X, game.CurrentPlayer);
        }

        // Testing: when a valid move is made, the current player changes to the other player
        [Fact]
        public void MakeMove_ValidMove_CorrectCurrentPlayer()
        {
            // Arrange
            TicTacToe ticTacToe = new TicTacToe();

            // Act
            ticTacToe.MakeMove(0, 0);

            // Assert
            Assert.Equal(TicTacToePlayer.O, ticTacToe.CurrentPlayer);
        }


        //Testing: when a valid move is made, the game state remains InProgress
        [Fact]
        public void MakeMove_ValidMove_StateInProgress()
        {
            // Arrange
            TicTacToe ticTacToe = new TicTacToe();

            // Act
            ticTacToe.MakeMove(0, 0);

            // Assert
            Assert.Equal(TicTacToeState.InProgress, ticTacToe.State);
        }

        // Testing: when an invalid move is made (i.e. select 3 which is out of range), an ArgumentException is thrown

        [Fact]
        public void MakeMove_InvalidMove_ArgumentException()
        {
            // Arrange
            TicTacToe ticTacToe = new TicTacToe();

            // Act and Assert
            Assert.Throws<ArgumentException>(() => ticTacToe.MakeMove(3, 0));
        }

        // Testing:  when an invalid row value is provided, an ArgumentException is thrown
        [Fact]
        public void MakeMove_ThrowsArgumentException_WhenRowIsInvalid()
        {
            // Arrange
            var ticTacToe = new TicTacToe();

            // Act & Assert
            Assert.Throws<ArgumentException>(() => ticTacToe.MakeMove(-1, 0));
            Assert.Throws<ArgumentException>(() => ticTacToe.MakeMove(3, 0));
        }

        // Testing:  when an invalid column value is provided, an ArgumentException is thrown
        [Fact]
        public void MakeMove_ThrowsArgumentException_WhenColumnIsInvalid()
        {
            // Arrange
            var ticTacToe = new TicTacToe();

            // Act & Assert
            Assert.Throws<ArgumentException>(() => ticTacToe.MakeMove(0, -1));
            Assert.Throws<ArgumentException>(() => ticTacToe.MakeMove(0, 3));
        }

        // Testing: when an invalid move is made (in this case, a negative row value), an ArgumentException is thrown
        [Fact]
        public void MakeMove_InvalidMove_ShouldThrowArgumentException()
        {
            // Arrange
            var game = new TicTacToe();

            // Act and assert
            Assert.Throws<ArgumentException>(() => game.MakeMove(-1, 0));
        }

        // Testing:  when a player makes a winning move, the game state changes to Win. Here, X wins by placing markers in the top row
        [Fact]
        public void MakeMove_WinningMove_StateWin()
        {
            // Arrange
            var ticTacToe = new TicTacToe();
            ticTacToe.MakeMove(0, 0); // X
            ticTacToe.MakeMove(1, 0); // O
            ticTacToe.MakeMove(0, 1); // X
            ticTacToe.MakeMove(1, 1); // O
            ticTacToe.MakeMove(0, 2); // X

            // Act
            ticTacToe.MakeMove(1, 2); // O, winning move

            // Assert
            Assert.Equal(TicTacToeState.Win, ticTacToe.State);
        }




    }
}
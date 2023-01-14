using System;
using static System.Console;

////////////////////
/// MAIN PROGRAM ///
////////////////////

class Program
{
    static void Main()
    {
        // Setup
        string[] boardSpaces = new string[9]; // 9 spaces for the board
        int turn = 1; 
        string[] endGameConditions = new string[2]; 
        bool endGame = false; 
        string result; 

        Game TicTacToe = new Game();
        boardSpaces = TicTacToe.buildBoard(boardSpaces);

        Player Player1 = new Player('X'); 
        Player Player2 = new Player('O');

        // Start Game
        while (endGame == false)
        {
            // Player 1 Turn
            Clear();
            TicTacToe.displayBoard(boardSpaces);
            boardSpaces = Player1.takePlayerMove(boardSpaces);
            Clear();
            TicTacToe.displayBoard(boardSpaces);
            endGameConditions = TicTacToe.isGameOver(boardSpaces, turn);
            turn++;

            if (endGameConditions[1] == "true")
            {
                endGame = true;
            }

            // Player 2 Turn
            if (endGame == false)
            {
                Clear();
                TicTacToe.displayBoard(boardSpaces);
                boardSpaces = Player2.takePlayerMove(boardSpaces);
                Clear();
                TicTacToe.displayBoard(boardSpaces);
                endGameConditions = TicTacToe.isGameOver(boardSpaces, turn);
                turn++;

                if (endGameConditions[1] == "true")
                {
                    endGame = true;
                }
            }
        }


        // End Game
        result = endGameConditions[0];
        WriteLine("Results: " + result);
        Write("Press any key to close: ");
        ReadKey();

    }
} 


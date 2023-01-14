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
        int turn = 1; // Counts the turns until they reach the maximum
        string[] endGameConditions = new string[2]; // Array to house ending results of game
        bool endGame = false; // Flag to end the turns and end the game
        string result; // String to print the results

        Game TicTacToe = new Game();
        boardSpaces = TicTacToe.buildBoard(boardSpaces);

        Player Player1 = new Player('X'); 
        Player Player2 = new Player('O');

        // Start Game
        TicTacToe.displayBoard(boardSpaces);

        while (endGame == false)
        {
            // Player 1 Turn
            boardSpaces = Player1.takePlayerMove(boardSpaces);
            TicTacToe.displayBoard(boardSpaces);
            endGameConditions = TicTacToe.isGameOver(boardSpaces, turn);
            turn++;

            if (endGameConditions[1] == "true")
            {
                endGame = true;
            }

            // Player 2 Turn (if game is not over yet)
            if (endGame == false)
            {
                boardSpaces = Player2.takePlayerMove(boardSpaces);
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
        if (endGameConditions[0] != "tie")
        {
            result = "The winner is " + endGameConditions[0];
            WriteLine("\n The End." + result);

        } else if (endGameConditions[0] == "tie")
        {
            result = "The game was a tie!";
            WriteLine("\n The End." + result);
        }

        Write("Press any key to close: ");
        ReadKey();

    }
} 


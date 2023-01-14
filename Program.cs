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

        Game TicTacToe = new Game();
        boardSpaces = TicTacToe.buildBoard(boardSpaces);

        Player Player1 = new Player('X'); 
        Player Player2 = new Player('O');

        // Start Game
        TicTacToe.displayBoard(boardSpaces);

        boardSpaces = Player1.takePlayerMove(boardSpaces);
        TicTacToe.displayBoard(boardSpaces);

        boardSpaces = Player2.takePlayerMove(boardSpaces);
        TicTacToe.displayBoard(boardSpaces);


        // End Game
        WriteLine("\n The End.");
        Write("Press any key to close: ");
        ReadKey();
    }
} 


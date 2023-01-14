using System;
using static System.Console;

class Program
{
    static void Main()
    {
        int Move;
        int[] boardSpaces = new int[9]; // 9 spaces for the board

        Game TicTacToe = new Game();
        boardSpaces = TicTacToe.displayBoard(boardSpaces.Length);

        Player Player1 = new Player(1, 'X');
        Player Player2 = new Player(2, 'O');

        //////////////////
        /// START GAME ///
        //////////////////
        Move = Player1.takePlayerMove();
        WriteLine(Move);
        Move = Player2.takePlayerMove();
        WriteLine(Move);



        //////////////////
        ///  END GAME  ///
        //////////////////

        //Write("Press any key to close: ");
        //ReadKey();
    }
} 


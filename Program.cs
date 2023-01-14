using System;
using static System.Console;

class Program
{
    static void Main()
    {
        int Move;
        Game TicTacToe = new Game();
        TicTacToe.displayBoard();

        Player Player1 = new Player(1, 'X');
        Player Player2 = new Player(2, 'O');

        Move = Player1.takePlayerMove();
        WriteLine(Move);
        //Write("Press any key to close: ");
        //ReadKey();
    }
} 


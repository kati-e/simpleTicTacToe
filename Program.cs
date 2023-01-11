using System;
using static System.Console;

class Program
{
    static void Main()
    {
        Game tictactoe = new Game();
        tictactoe.displayBoard();

        Write("Press any key to close: ");
        ReadKey();
    }
} 


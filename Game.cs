using System;
using static System.Console;

public class Game
{
    public void displayBoard()
    {
        WriteLine("-----------------------------------");
        WriteLine("| Welcome to my simple TicTacToe! |");
        WriteLine("-----------------------------------");
        WriteLine("    Player 1: X    Player 2: O");
        WriteLine("-----------------------------------");
        WriteLine("\n");
        WriteLine("          X  |  X  |  X       ");
        WriteLine("         ----------------     ");
        WriteLine("          X  |  X  |  X       ");
        WriteLine("         ----------------     ");
        WriteLine("          X  |  X  |  X       ");
        WriteLine("\n");
    }
}
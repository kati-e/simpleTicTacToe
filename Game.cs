using System;
using static System.Console;

public class Game
{
    public void displayBoard()
    {

        int[] spaces = new int[9]; // 9 spaces on the board

        for (int i = 0; i < spaces.Length; i++)
        {
            spaces[i] = i + 1;
        }

        WriteLine("-----------------------------------");
        WriteLine("| Welcome to my simple TicTacToe! |");
        WriteLine("-----------------------------------");
        WriteLine("    Player 1: X    Player 2: O");
        WriteLine("-----------------------------------");
        WriteLine("\n");
        WriteLine("          " + spaces[0] + "  |  " + spaces[1] + "  |  " + spaces[2] + "       ");
        WriteLine("         ----------------     ");
        WriteLine("          " + spaces[3] + "  |  " + spaces[4] + "  |  " + spaces[5] + "       ");
        WriteLine("         ----------------     ");
        WriteLine("          " + spaces[6] + "  |  " + spaces[7] + "  |  " + spaces[8] + "       ");
        WriteLine("\n");
    }
}
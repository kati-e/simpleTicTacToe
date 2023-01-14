using System;
using static System.Console;

//////////////////
///    GAME    ///
//////////////////

public class Game
{
    // Creates the starting game board
    public string[] buildBoard(string[] boardspaces)
    {

        for (int i = 0; i < boardspaces.Length; i++)
        {
            boardspaces[i] = Convert.ToString((i + 1));
        }

        return boardspaces;
    }

    // Displays game board
    public void displayBoard(string[] boardspaces)
    {
        WriteLine("-----------------------------------");
        WriteLine("| Welcome to my simple TicTacToe! |");
        WriteLine("-----------------------------------");
        WriteLine("    Player 1: X    Player 2: O");
        WriteLine("-----------------------------------");
        WriteLine("\n");
        WriteLine("          " + boardspaces[0] + "  |  " + boardspaces[1] + "  |  " + boardspaces[2] + "       ");
        WriteLine("         ----------------     ");
        WriteLine("          " + boardspaces[3] + "  |  " + boardspaces[4] + "  |  " + boardspaces[5] + "       ");
        WriteLine("         ----------------     ");
        WriteLine("          " + boardspaces[6] + "  |  " + boardspaces[7] + "  |  " + boardspaces[8] + "       ");
        WriteLine("\n");
    }
}
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

    // Checked Game Over Condition
    public string[] isGameOver(string[] boardspaces, int turn)
    {
        string[] over = { "", "false" };

        //Board drawing with indecies 
        // 0 | 1 | 2
        // 3 | 4 | 5
        // 6 | 7 | 8

        if (turn == boardspaces.Length)
        {
            over[0] = "It's a tie!";
            over[1] = "true";

        } else if (
         boardspaces[0] == "X" && boardspaces[1] == "X" && boardspaces[2] == "X" ||
         boardspaces[0] == "X" && boardspaces[3] == "X" && boardspaces[6] == "X" ||
         boardspaces[0] == "X" && boardspaces[4] == "X" && boardspaces[8] == "X" ||
         boardspaces[3] == "X" && boardspaces[4] == "X" && boardspaces[5] == "X" ||
         boardspaces[6] == "X" && boardspaces[7] == "X" && boardspaces[8] == "X" ||
         boardspaces[1] == "X" && boardspaces[4] == "X" && boardspaces[7] == "X" ||
         boardspaces[2] == "X" && boardspaces[5] == "X" && boardspaces[8] == "X"
         )
        {
            over[0] = "Player 1 is the winner!";
            over[1] = "true";

        } else if (
            boardspaces[0] == "O" && boardspaces[1] == "O" && boardspaces[2] == "O" ||
            boardspaces[0] == "O" && boardspaces[3] == "O" && boardspaces[6] == "O" ||
            boardspaces[0] == "O" && boardspaces[4] == "O" && boardspaces[8] == "O" ||
            boardspaces[3] == "O" && boardspaces[4] == "O" && boardspaces[5] == "O" ||
            boardspaces[6] == "O" && boardspaces[7] == "O" && boardspaces[8] == "O" ||
            boardspaces[1] == "O" && boardspaces[4] == "O" && boardspaces[7] == "O" ||
            boardspaces[2] == "O" && boardspaces[5] == "O" && boardspaces[8] == "O"
            )
        {
            over[0] = "Player 2 is the winner!";
            over[1] = "true";
        } 

        return over;
    }
}
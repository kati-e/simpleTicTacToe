using System;
using static System.Console;

//////////////////
///   PLAYER   ///
//////////////////

public class Player
{
    public char playerPiece;

    public Player(char PlayerPiece)
    {
        playerPiece = PlayerPiece;
    }

    // Take user input for player's move
    public string[] takePlayerMove(string[] boardspaces)
    {
        Write("Make your move: ");
        int move = Convert.ToInt32(ReadLine());

        bool valid = isMoveValid(move, boardspaces);

        while (!valid)
        {
            Write("Try again... ");
            move = Convert.ToInt32(ReadLine());
            valid = isMoveValid(move, boardspaces);
        }

        boardspaces = addMoveToBoard(move, boardspaces);

        return boardspaces;
    }

    // Checking if move choice is legal based on current board state
    private bool isMoveValid(int move, string[] boardspaces)
    {
        bool valid = false;
        string Move = Convert.ToString(move);

        for (int i = 0; i < boardspaces.Length; i++)
        {
            if (boardspaces[i] == Move)
            {
                valid = true;
            } 
        }

        return valid;
    }

    // Adds the user input into the boardspaces array
    private string[] addMoveToBoard(int move, string[] boardspaces)
    {
        for (int i = 0; i < boardspaces.Length; i++)
        {
            string Move = Convert.ToString(move);
            
            if (boardspaces[i] == Move)
            {
                boardspaces[i] = Convert.ToString(playerPiece);
            }
        }

        return boardspaces;
    }
} 

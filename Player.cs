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

        bool valid = isMoveValid(move);

        while (!valid)
        {
            Write("Try again... ");
            move = Convert.ToInt32(ReadLine());
            valid = isMoveValid(move);
        }

        boardspaces = addMoveToBoard(move, boardspaces);
        return boardspaces;
    }

    // Check if the move is valid
    public bool isMoveValid(int move)
    {
        bool valid;

        if (move < 1 || move > 9)
        {
            valid = false;
        } else
        {
            valid = true;
        }

        return valid;
    }

    // Adds the user input into the boardspaces array
    public string[] addMoveToBoard(int move, string[] boardspaces)
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

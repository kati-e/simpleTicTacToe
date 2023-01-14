using System;
using static System.Console;

public class Player
{
    public int playerNum;
    public char playerPiece;

    // Constructor
    public Player(int PlayerNum, char PlayerPiece)
    {
        playerNum = PlayerNum;
        playerPiece = PlayerPiece;
    }

    // Take user input for player's move
    public int takePlayerMove()
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

        return move;
    }

    // Check if the move is valid
    public bool isMoveValid(int move)
    {
        bool valid;

        // first, check if it is within the correct number range for the board spaces.
        if (move < 1 || move > 8)
        {
            valid = false;
        } else
        {
            valid = true;
        }

        return valid;
    }

} 

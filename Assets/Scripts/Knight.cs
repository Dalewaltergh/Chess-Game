using UnityEngine;
using System.Collections.Generic;

public class Knight : Chessman
{
    public override bool[,] PossibleMove()
    {
        bool[,] r = new bool[8, 8];

        // UPLEFT
        KnightMove(CurrentX - 1, CurrentY + 2, ref r);

        // UPRIGHT
        KnightMove(CurrentX + 1, CurrentY + 2, ref r);

        // RIGHT UP
        KnightMove(CurrentX + 2, CurrentY + 1, ref r);

        // RIGHT DOWN
        KnightMove(CurrentX + 2, CurrentY - 1, ref r);

        // DOWN LEFT
        KnightMove(CurrentX - 1, CurrentY - 2, ref r);

        // DOWN RIGHT
        KnightMove(CurrentX + 1, CurrentY - 2, ref r);

        // lEFT UP
        KnightMove(CurrentX - 2, CurrentY + 1, ref r);

        // LEFT DOWN
        KnightMove(CurrentX - 2, CurrentY - 1, ref r);

        return r;
    }

    public void KnightMove(int x, int y, ref bool[,] r)
    {
        Chessman c;
        if (x >= 0 && x < 8 && y >= 0 && y < 8)
        {
            c = BoardManager.Instance.Chessmans[x, y];
            if (c == null)
                r[x, y] = true;
            else if (isWhite != c.isWhite)
                r[x, y] = true;
        }
    }

}
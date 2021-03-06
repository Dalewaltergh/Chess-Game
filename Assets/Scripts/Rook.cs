using UnityEngine;
using System.Collections.Generic;

public class Rook : Chessman
{
    public override bool[,] PossibleMove()
    {
        bool[,] r = new bool[8, 8];

        Chessman c; 
        int i;

        // RIGHT
        i = CurrentX;
        while (true)
        {
            i++;
            if (i >= 8) break;

            c = BoardManager.Instance.Chessmans [i, CurrentY];
            if (c == null)
                r[i, CurrentY] = true;
            else 
            {
                if (c.isWhite != isWhite) 
                    r[i, CurrentY] = true;

                break;
            } 
        }

        // LEFT
        i = CurrentX;
        while (true)
        {
            i--;
            if (i < 0) break;

            c = BoardManager.Instance.Chessmans [i, CurrentY];
            if (c == null)
                r[i, CurrentY] = true;
            else 
            {
                if (c.isWhite != isWhite) 
                    r[i, CurrentY] = true;

                break;
            } 
        }

        // UP
        i = CurrentY;
        while (true)
        {
            i++;
            if (i >= 8) break;

            c = BoardManager.Instance.Chessmans [CurrentX, i];
            if (c == null)
                r[CurrentX, i] = true;
            else 
            {
                if (c.isWhite != isWhite) 
                    r[CurrentX, i] = true;

                break;
            } 
        }
        
        // DOWN
        i = CurrentY;
        while (true)
        {
            i--;
            if (i < 0) break;

            c = BoardManager.Instance.Chessmans [CurrentX, i];
            if (c == null)
                r[CurrentX, i] = true;
            else 
            {
                if (c.isWhite != isWhite) 
                    r[CurrentX, i] = true;

                break;
            } 
        }

        return r;
    }
}
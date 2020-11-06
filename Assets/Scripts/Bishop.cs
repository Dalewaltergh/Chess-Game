using UnityEngine;
using System.Collections.Generic;

public class Bishop : Chessman
{
    public override bool[,] PossibleMove()
    {
        bool[,] r = new bool[8, 8];

        Chessman c;

        int i, j;

        // TOP LEFT
        i = CurrentX;
        j = CurrentY;
        while(true)
        {
            i--;
            j++;
            if (i < 0 || j >= 8) break;

            c = BoardManager.Instance.Chessmans[i, j];
            if (c == null)
                r[i, j] = true;
            else 
            {
                if (isWhite != c.isWhite) 
                    r [i, j] = true;
                
                break;
            }
        }

        // TOP RIGHT
        i = CurrentX;
        j = CurrentY;
        while(true)
        {
            i++;
            j++;
            if (i >= 8 || j >= 8) break;

            c = BoardManager.Instance.Chessmans[i, j];
            if (c == null)
                r[i, j] = true;
            else 
            {
                if (isWhite != c.isWhite) 
                    r [i, j] = true;
                
                break;
            }
        }

        // DOWN LEFT
        i = CurrentX;
        j = CurrentY;
        while(true)
        {
            i--;
            j--;
            if (i < 0 || j < 0) break;

            c = BoardManager.Instance.Chessmans[i, j];
            if (c == null)
                r[i, j] = true;
            else 
            {
                if (isWhite != c.isWhite) 
                    r [i, j] = true;
                
                break;
            }
        }

        // DOWN RIGHT
        i = CurrentX;
        j = CurrentY;
        while(true)
        {
            i++;
            j--;
            if (i >= 8 || j < 0) break;

            c = BoardManager.Instance.Chessmans[i, j];
            if (c == null)
                r[i, j] = true;
            else 
            {
                if (isWhite != c.isWhite) 
                    r [i, j] = true;
                
                break;
            }
        }

        return r;
    }
}
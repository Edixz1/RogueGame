using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Grid 
{
    private int width;
    private int hight;
    public int[,] gridArray;

    public Grid(int width, int hight)
    {
        this.width = width;
        this.hight = hight;

        gridArray = new int[width, hight];

        for (int x = 0; x < gridArray.GetLength(0); x++)
        {
            for (int y = 0; y < gridArray.GetLength(1); y++)
            {

            }
        }
    }
}

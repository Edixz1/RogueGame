using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManagement : MonoBehaviour
{
    public int width, height;
    public TileComponent tilePrefab;

    void GenerateGrid()
    {
        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                var spawnedTile = Instantiate(tilePrefab, new Vector2(x, y), Quaternion.identity);
                spawnedTile.name = "Tile (" + x+ "," + y + ")";
            }
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        GenerateGrid();
    }
}

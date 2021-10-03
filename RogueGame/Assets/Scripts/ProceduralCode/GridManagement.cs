using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManagement : MonoBehaviour
{
    public int width, height;
    private float cellWidth;
    private float cellHeight;
    public GameObject tilePrefab;

    void GenerateGrid()
    {
        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                var spawnedTile = Instantiate(tilePrefab, new Vector3(x*cellWidth,y*cellHeight), Quaternion.identity);
                spawnedTile.name = "Tile (" + x+ "," + y + ")";
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        cellWidth = tilePrefab.transform.localScale.x;
        cellHeight = tilePrefab.transform.localScale.y;
        GenerateGrid();
        Debug.Log(cellWidth + " : " + cellHeight);
    }
}

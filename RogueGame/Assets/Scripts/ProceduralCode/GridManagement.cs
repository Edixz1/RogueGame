using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManagement : MonoBehaviour
{
    public int width, height;
    public GameObject[] tilePossibillity;
    public GameObject tilePrefab;
    public GameObject tlieSize;

    private float cellWidth;
    private float cellHeight;
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
        cellWidth = tlieSize.transform.localScale.x;
        cellHeight = tlieSize.transform.localScale.y;

        //int rand = Random.Range(0, tilePossibillity.Length);

        GenerateGrid();
    }
}

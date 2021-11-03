using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomTemplate : MonoBehaviour
{
    public GameObject[] bottomRooms;
    public GameObject[] topRooms;
    public GameObject[] leftRooms;
    public GameObject[] rightRooms;

    public GameObject closerRoom;

    public List<GameObject> rooms;
    public List<GameObject> closerRooms;

    public float waitTime;
    private bool spawnedBoss;
    public GameObject boss;

    private void Update()
    {
        if(waitTime <= 0 && !spawnedBoss) 
        {
            for (int i = 0; i < rooms.Count; i++)
            {
                if(i == rooms.Count - 1 )
                {
                    Instantiate(boss, rooms[i].transform.position, Quaternion.identity);
                    closerRooms[0].SetActive(false);
                    spawnedBoss = true;
                }
            }
        }
        else
        {
            waitTime -= Time.deltaTime;
        }
    }
}

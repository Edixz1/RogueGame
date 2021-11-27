using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;
public class RoomTemplate : MonoBehaviour
{
    public GameObject[] bottomRooms;
    public GameObject[] topRooms;
    public GameObject[] leftRooms;
    public GameObject[] rightRooms;

    public GameObject closerRoom;

    public List<GameObject> rooms;

    public float waitTime;
    private bool spawnedBoss;
    public GameObject bossRoom;
    public static GameObject bar;
    public static GameObject victory;
    //public GameObject bossCleaner;
    //public GameObject boss;
    private void Start()
    {
        bar = GameObject.FindGameObjectWithTag("BossBar");
        victory = GameObject.FindGameObjectWithTag("Victory");
        bar.SetActive(false);
        victory.SetActive(false);
    }
    private void Update()
    {

        if(waitTime <= 0 && !spawnedBoss) 
        {
            for (int i = 0; i < rooms.Count; i++)
            {
                if (i == rooms.Count - 1)
                {
                    
                    //Instantiate(bossCleaner, rooms[rooms.Count-1].transform.position, Quaternion.identity);
                    Invoke("SummonBoss", 1f);
                    spawnedBoss = true;
                }
            }
        }
        else
        {
            waitTime -= Time.deltaTime;
        }
    }
    private void SummonBoss() 
    {
        int lastRoomIndex = rooms.Count - 1;
        Vector3 lastRoomPosition = rooms[lastRoomIndex].transform.position;
        Destroy(rooms[lastRoomIndex]);
        Instantiate(bossRoom, lastRoomPosition, Quaternion.identity);
        AstarPath.active.Scan();
    }
}

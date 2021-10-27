using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProceduralGeneration : MonoBehaviour
{
    public int openingDirection;
    //1 bottom
    //2 top
    //3 left
    //4 right
    private RoomTemplate templates;
    private int rand;
    private bool spawned = false;
    private void Start()
    {
        templates = GameObject.FindGameObjectWithTag("Rooms").GetComponent<RoomTemplate>();
        Debug.Log(templates);
        //Se get Gizmo 0 son transform faire une variable
        Invoke("Spawn", 0.01f);
    }

    void Spawn()
    {
        if (!spawned)
        {
            if(openingDirection == 0)
            {
                //GameObject temps = gizmo0.transform;
            }

            if (openingDirection == 1)
            {
                rand = Random.Range(0, templates.bottomRooms.Length);
                Instantiate(templates.bottomRooms[rand],new Vector3(transform.position.x + 14.7f,2.5f,0), Quaternion.identity);
            }
            else if (openingDirection == 2)
            {
                rand = Random.Range(0, templates.topRooms.Length);
                Instantiate(templates.topRooms[rand], new Vector3(14.7f, 2.5f, 0), Quaternion.identity);
            }
            else if (openingDirection == 3)
            {
                rand = Random.Range(0, templates.leftRooms.Length);
                Instantiate(templates.leftRooms[rand], new Vector3(14.7f, 2.5f, 0), Quaternion.identity);
            }
            else if (openingDirection == 4)
            {
                rand = Random.Range(0, templates.rightRooms.Length);
                Instantiate(templates.rightRooms[rand], new Vector3(14.7f, 2.5f, 0), Quaternion.identity);
            }
            spawned = true;
        }
    }
}

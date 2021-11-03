using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddClose : MonoBehaviour
{
    private RoomTemplate temp;
    private void Start()
    {
        temp = GameObject.FindGameObjectWithTag("Rooms").GetComponent<RoomTemplate>();
        temp.closerRooms.Add(this.gameObject);
    }
}

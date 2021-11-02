using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorscriptComponent : MonoBehaviour
{
    public int ennemiesAlive;
    public bool ennemiesAreAlive;
    GameObject Ennemies;
    GameObject Doors;
    // Start is called before the first frame update
    void Awake()
    {
        Doors = this.transform.Find("Doors").gameObject;
        GameObject map = this.gameObject;
        GameObject Spawner = this.transform.Find("Spawners").gameObject;
        Ennemies = Spawner.transform.GetChild(0).gameObject;
        ennemiesAlive = Ennemies.transform.childCount;
        ennemiesAreAlive = false;
    }
    
    
    private void OnTriggerStay2D(Collider2D collision)
    {
        for(int i = 0; i < Ennemies.transform.childCount; i++)
        {
            if (Ennemies.transform.GetChild(i).gameObject.activeInHierarchy)
            {
                ennemiesAlive++;
            }
        }
        if (ennemiesAlive == 0 && collision.gameObject.layer == 10)
        {
            collision.gameObject.SetActive(false);
            Doors.SetActive(false);
        }
        ennemiesAlive = 0;
    }
}

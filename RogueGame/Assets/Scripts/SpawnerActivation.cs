using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerActivation : MonoBehaviour
{
    private void OnBecameVisible()
    {
        GameObject spawners = this.transform.parent.gameObject.transform.Find("Spawners").gameObject;
        Component doorsscript = this.transform.parent.gameObject.GetComponent<DoorscriptComponent>();
        spawners.SetActive(true);
        //doorsscript
    }
    
}

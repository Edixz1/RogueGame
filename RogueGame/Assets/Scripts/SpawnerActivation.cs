using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerActivation : MonoBehaviour
{
    private void OnBecameVisible()
    {
        Debug.Log("ONBECOMEVISIBLE");
        GameObject spawners = this.transform.parent.gameObject.transform.Find("Spawners").gameObject;
        spawners.SetActive(true);
    }
    
}

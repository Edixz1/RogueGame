using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMouvementComponent : MonoBehaviour
{
    public GameObject Camera;
    public GameObject Personnage;
    void Awake()
    {
        Camera = GameObject.Find("Main Camera");
        Personnage = GameObject.Find("Personnage");
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(Camera.transform.position, Personnage.transform.position);
        if (distance >= 11)
        {
            Camera.transform.position = new Vector3(Personnage.transform.position.x,Personnage.transform.position.y,Camera.transform.position.z);
        }
    }
}

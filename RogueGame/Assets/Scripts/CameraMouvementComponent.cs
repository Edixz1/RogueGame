using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMouvementComponent : MonoBehaviour
{
    private float ValueHorizontale = 33.189f;
    private float valueVerticale = 18.81f;
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
        if (Personnage.transform.position.x - Camera.transform.position.x >= ValueHorizontale /2)
        {
            
            Camera.transform.position = new Vector3(Camera.transform.position.x + ValueHorizontale,Personnage.transform.position.y,Camera.transform.position.z);
        }
        if (Personnage.transform.position.y - Camera.transform.position.y >= valueVerticale /2)
        {
            Camera.transform.position = new Vector3(Camera.transform.position.x, Camera.transform.position.y + valueVerticale, Camera.transform.position.z);
        }
    }
}

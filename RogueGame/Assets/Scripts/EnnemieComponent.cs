using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemieComponent : MonoBehaviour
{
    int layerMask = 6;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Physics.Raycast(transform.position, Vector3.forward, Mathf.Infinity, layerMask))
        {

        }
    }
}

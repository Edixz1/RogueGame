using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerColisionComposent : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        int layerMask = 6;

        if (Physics.Raycast(transform.position, Vector3.forward, Mathf.Infinity, layerMask))
        {
            Debug.Log("coolBEan");
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MCmovementComponent : MonoBehaviour
{
    private float movementSpeed = 7.5f;
    public GameObject MainCharacter;
    // Start is called before the first frame update
    void Start()
    {
        MainCharacter = GameObject.Find("Personnage");
    }

    // Update is called once per frame
    void Update()
    {
       //get the Input from Horizontal axis
        float horizontalInput = Input.GetAxis("Horizontal");
        //get the Input from Vertical axis
        float verticalInput = Input.GetAxis("Vertical");

        //update the position
        MainCharacter.transform.position = MainCharacter.transform.position + new Vector3(horizontalInput * movementSpeed * Time.deltaTime, verticalInput * movementSpeed * Time.deltaTime, 0);
    }
}

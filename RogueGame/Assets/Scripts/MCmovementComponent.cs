using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MCmovementComponent : MonoBehaviour
{
    public InputAction moveX;
    public InputAction moveY;
    public float movementSpeed = 1;
    public Rigidbody2D rb;

    private bool isMovingX = false;
    private bool isMovingY = false;

    void Awake()
    {
        moveX.Enable();
        moveX.started += _ => isMovingX = true;
        moveX.canceled += _ => isMovingX = false;

        moveY.Enable();
        moveY.started += _ => isMovingY = true;
        moveY.canceled += _ => isMovingY = false;
    }

    // Update is called once per frame
    void Update()
    {
        float deltaX = moveX.ReadValue<float>();
        float deltaY = moveY.ReadValue<float>();
        Debug.Log("X" + isMovingX);
        Debug.Log("Y" + isMovingY);
        if (isMovingX || isMovingY)
            rb.velocity = new Vector2(deltaX, 0) * movementSpeed;
        else
            rb.velocity = new Vector2(0, 0) * movementSpeed;
        if (isMovingY)
            rb.velocity = new Vector2(0, deltaY) * movementSpeed;
        else
            rb.velocity = new Vector2(0, 0) * movementSpeed;
        //if (isMovingY)
        // Move(new Vector2(0, deltaY));

    }
    //private void Move(Vector2 delta) => ;
    
}
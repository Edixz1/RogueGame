using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerComponent : MonoBehaviour
{
    public float movementSpeed = 1;
    public LayerMask ennemiLayer;
    public Rigidbody2D rb;

    private float horizontal;
    private float vertical;
    private float lastLooking;
    private bool isFacingRight = true;


    void Update()
    {

        rb.velocity = new Vector2(horizontal * movementSpeed, vertical * movementSpeed);
        if (!isFacingRight && horizontal > 0f)
        {
            //Flip();
        }
        else if (isFacingRight && horizontal < 0f)
        {
            //Flip();
        }

    }

    private void Flip()
    {
        isFacingRight = !isFacingRight;
        Vector3 localScale = transform.localScale;
        localScale.x *= -1f;
        transform.localScale = localScale;
    }

    public void Move(InputAction.CallbackContext context)
    {
        horizontal = context.ReadValue<Vector2>().x;
        vertical = context.ReadValue<Vector2>().y;
    }

    public void Dash(InputAction.CallbackContext context)
    {
        movementSpeed = movementSpeed * 2;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("ok");

        if (gameObject.layer == 6)
            Debug.Log("ok2");
    }
}

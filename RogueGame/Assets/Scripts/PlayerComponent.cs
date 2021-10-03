using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class PlayerComponent : MonoBehaviour
{
    public float movementSpeed = 1;
    public float dashDistance = 100;
    public LayerMask ennemiLayer;
    public Rigidbody2D rb;
    public Image abilityDash;
    public float coolDown = 5;

    private float horizontal;
    private float vertical;
    private Vector2 lastMovement;

    private bool isFacingRight = true;
    private bool isDashing = false;
    private bool isCoolDown = false;

    private void Start()
    {
        abilityDash.fillAmount = 0;
    }
    void Update()
    {
        rb.velocity = new Vector2(horizontal * movementSpeed, vertical * movementSpeed);
        HandleDash();

        RaycastHit2D raycastHit = Physics2D.Raycast(transform.position, lastMovement, dashDistance);
        Debug.Log(raycastHit.collider);
        Debug.DrawLine(rb.position, new Vector2(transform.position.x + (lastMovement.x * dashDistance), transform.position.y + (lastMovement.y * dashDistance)), Color.red, 2);
        if (!isFacingRight && horizontal > 0f)
        {
            Flip();
        }
        else if (isFacingRight && horizontal < 0f)
        {
            Flip();
        }

        

    }
    private void HandleDash()
    {
        if (isDashing)
        {
            isCoolDown = true;
            abilityDash.fillAmount = 1;

            rb.MovePosition(new Vector2(transform.position.x + (lastMovement.x * dashDistance), transform.position.y + (lastMovement.y * dashDistance)));
            isDashing = false;
        }
        if (isCoolDown)
        {
            abilityDash.fillAmount -= 1 / coolDown * Time.deltaTime;
            if (abilityDash.fillAmount <= 0)
            {
                abilityDash.fillAmount = 0;
                isCoolDown = false;
            }
        }
    }
    private void Flip()
    {
        isFacingRight = !isFacingRight;
        transform.Rotate(0f, 180f,0f);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.gameObject.layer == 6)
            HeartComponent.health -= 0.1f;   
    }
    //InputSystem Get
    public void Move(InputAction.CallbackContext context)
    {
        lastMovement = new Vector2(horizontal, vertical).normalized;
        horizontal = context.ReadValue<Vector2>().x;
        vertical = context.ReadValue<Vector2>().y;

        
    }

    public void Dash(InputAction.CallbackContext context)
    {
        if(isCoolDown == false)
            isDashing = true;
    }
    

    
}

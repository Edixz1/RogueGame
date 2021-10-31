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
    public List<Item> inventaire;
    public GameObject menuPause;

    private float horizontal;
    private float vertical;
    private Vector2 lastMovement;

    private bool isFacingRight = true;
    private bool isDashing = false;
    private bool isCoolDown = false;
    private bool isPause = false;


    static SpriteRenderer sr;
    public static bool isBlinking = false;

    private void Start()
    {
        
        menuPause.SetActive(false);
        abilityDash.fillAmount = 0;
        sr = GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        rb.velocity = new Vector2(horizontal * movementSpeed, vertical * movementSpeed);
        HandleDash();

        RaycastHit2D raycastHit = Physics2D.Raycast(transform.position, lastMovement, dashDistance);
        //Debug.Log(raycastHit.collider);
        //Debug.DrawLine(rb.position, new Vector2(transform.position.x + (lastMovement.x * dashDistance), transform.position.y + (lastMovement.y * dashDistance)), Color.red, 2);
       /* if (!isFacingRight && horizontal > 0f)
        {
            Flip();
        }
        else if (isFacingRight && horizontal < 0f)
        {
            Flip();
        }
       */
        

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
            HeartComponent.TakeDamage();   
    }
    //InputSystem Get
    public void Move(InputAction.CallbackContext context)
    {
        lastMovement = new Vector2(horizontal, vertical).normalized;
        horizontal = context.ReadValue<Vector2>().x;
        vertical = context.ReadValue<Vector2>().y;

        
    }

    public void Pause(InputAction.CallbackContext context)
    {
        isPause = !isPause;
        if(isPause)
        {

            menuPause.SetActive(true);
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
            menuPause.SetActive(false);
        }

    }

    public void Dash(InputAction.CallbackContext context)
    {
        if(isCoolDown == false)
            isDashing = true;
    }
    
    public static IEnumerator Blink()
    {
        Debug.Log("Started Coroutine at timestamp : " + Time.time);
        sr.color = new Color(1,1,1,0);
        yield return new WaitForSeconds(.1f);
        sr.color = new Color(1, 1, 1, 1);
        Debug.Log("Finished Coroutine at timestamp : " + Time.time);
    }


}

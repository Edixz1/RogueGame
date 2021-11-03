using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lolipopHead : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 20;
    bool parentDirection;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(transform.position.x*speed, transform.position.y);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            HeartComponent.TakeDamage();
            Destroy(gameObject);
            FindObjectOfType<audioManager>().Play("PlayerIsHit");
        }
        else if (collision.CompareTag("Wall") || collision.CompareTag("Vide"))
        {
            Destroy(gameObject);
            FindObjectOfType<audioManager>().Play("EnemyIsHit");
        }
        
    }
}

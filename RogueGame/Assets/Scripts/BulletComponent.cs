using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletComponent : MonoBehaviour
{
    public static float speed = 20f;
    public static float damage = 1;
    public static Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        EnnemieComponent ennemie = collision.GetComponent<EnnemieComponent>();
        
        if(ennemie != null)
        {
            ennemie.TakeDomage(damage);
        }
        Destroy(gameObject);
    }
}

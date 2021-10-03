using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletComponent : MonoBehaviour
{
    public float speed = 20f;
    public float damage = 1;
    public Rigidbody2D rb;
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
        Debug.Log(collision.name);
        EnnemieComponent ennemie = collision.GetComponent<EnnemieComponent>();
        Debug.Log(ennemie);
        if(ennemie != null)
        {
            ennemie.TakeDomage(damage);
        }
        Destroy(gameObject);
    }
}

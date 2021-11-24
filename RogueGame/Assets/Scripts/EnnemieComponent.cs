using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemieComponent : MonoBehaviour
{
    public float health = 10;
    public GameObject drop;
    public void TakeDomage(float damage)
    {
        health -= damage;
        FindObjectOfType<audioManager>().Play("EnemyIsHit");
        if(health <=0)
        {
            Die();
        }
    }
    void Die()
    {
        int random = Random.Range(0, 9);
        if (random == 0)
        {
            Instantiate(drop, transform.position, Quaternion.identity);
        }
        Destroy(gameObject);
    }
}

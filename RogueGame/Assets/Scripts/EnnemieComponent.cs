using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemieComponent : MonoBehaviour
{
    public float health = 10;
    public GameObject healthDrop;
    public GameObject[] ItemDrops;
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
            Instantiate(healthDrop, transform.position, Quaternion.identity);
        }
        else if (random == 9)
        {
            Instantiate(ItemDrops[Random.Range(0,4)], transform.position, Quaternion.identity);
        }
        Destroy(gameObject);
    }
}

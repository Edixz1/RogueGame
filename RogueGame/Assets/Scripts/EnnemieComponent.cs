using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemieComponent : MonoBehaviour
{
    public float health = 10;
    public void TakeDomage(float damage)
    {
        health -= damage;

        if(health <=0)
        {
            Die();
        }
    }
    void Die()
    {
        Destroy(gameObject);
    }
}

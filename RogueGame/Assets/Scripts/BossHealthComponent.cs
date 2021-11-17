using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossHealthComponent : MonoBehaviour
{

    public static float health;
    public float maxHealth;
    public Slider slider;
    // Start is called before the first frame update
    void Start()
    {
        slider.maxValue = maxHealth;
        health = maxHealth;
    }
    public void TakeDomage(float damage)
    {
        health -= damage;
        FindObjectOfType<audioManager>().Play("EnemyIsHit");
        if (health <= 0)
        {
            slider.value = 0;
            Die();
        }
    }
    void Die()
    {
        Destroy(gameObject);
    }
    // Update is called once per frame
    void Update()
    {
        if (health > 0)
        {
            slider.value = health;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeartComponent : MonoBehaviour
{
    public GameObject heart, gameOver;
    public Sprite Dent1, Dent2, Dent3, Dent4, Dent5;
    public Gradient gradient;
    public static float health;
    public Slider slider;
    public Image fill;
    // Start is called before the first frame update
    void Start()
    {
        health = 1;
        slider.maxValue = health;
        slider.value = health;
        fill.color = gradient.Evaluate(1f);
        /*heart1.gameObject.SetActive(true);
        heart2.gameObject.SetActive(true);
        heart3.gameObject.SetActive(true);

        gameOver.gameObject.SetActive(false);*/

    }

    // Update is called once per frame
    void Update()
    {
        slider.value = health;
        fill.color = gradient.Evaluate(slider.normalizedValue);
        Debug.Log(slider.normalizedValue);
        if(health <= 0)
        {
            gameOver.gameObject.SetActive(true);
            Time.timeScale = 0;
        }
            
        
        if (health > 1) health = 1;
        /*switch (health)
        {
            case 3:
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(true);
                heart3.gameObject.SetActive(true);
                break;
            case 2:
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(true);
                heart3.gameObject.SetActive(false);
                break;
            case 1:
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(false);
                heart3.gameObject.SetActive(false);
                break;
            case 0:
                heart1.gameObject.SetActive(false);
                heart2.gameObject.SetActive(false);
                heart3.gameObject.SetActive(false);
                Time.timeScale = 0;
                break;
        }*/
    }
}

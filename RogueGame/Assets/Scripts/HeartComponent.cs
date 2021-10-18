using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeartComponent : MonoBehaviour
{
    public GameObject heart, gameOver;
    public Image Dent, Dent1, Dent2, Dent3, Dent4;
    public Gradient gradient;
    public static float health;
    public Slider slider;
    public Image fill;
    public static float maxHealth;
    // Start is called before the first frame update
    void Start()
    {
        maxHealth = slider.maxValue;
        health = slider.maxValue;
        slider.maxValue = health;
        slider.value = health;
        fill.color = gradient.Evaluate(1f);
        Dent.gameObject.SetActive(true);
        Dent1.gameObject.SetActive(false);
        Dent2.gameObject.SetActive(false);
        Dent3.gameObject.SetActive(false);
        Dent4.gameObject.SetActive(false);
        /*heart1.gameObject.SetActive(true);
        heart2.gameObject.SetActive(true);
        heart3.gameObject.SetActive(true);

        gameOver.gameObject.SetActive(false);*/

    }

    // Update is called once per frame
    void Update()
    {
        slider.maxValue = maxHealth;
        slider.value = health;
        fill.color = gradient.Evaluate(slider.normalizedValue);
        

        switch(Mathf.Round(slider.normalizedValue * 10)) { 
            case 10:
                Dent.gameObject.SetActive(true);
                Dent1.gameObject.SetActive(false);
                Dent2.gameObject.SetActive(false);
                Dent3.gameObject.SetActive(false);
                Dent4.gameObject.SetActive(false);
            break;

            case 8:
                Dent.gameObject.SetActive(true);
                Dent1.gameObject.SetActive(false);
                Dent2.gameObject.SetActive(false);
                Dent3.gameObject.SetActive(false);
                Dent4.gameObject.SetActive(false);
                break;

            case 7:
                Dent.gameObject.SetActive(false);
                Dent1.gameObject.SetActive(true);
                Dent2.gameObject.SetActive(false);
                Dent3.gameObject.SetActive(false);
                Dent4.gameObject.SetActive(false);
                break;

            case 5:
                Dent.gameObject.SetActive(false);
                Dent1.gameObject.SetActive(false);
                Dent2.gameObject.SetActive(true);
                Dent3.gameObject.SetActive(false);
                Dent4.gameObject.SetActive(false);
                break;

            case 3:
                Dent.gameObject.SetActive(false);
                Dent1.gameObject.SetActive(false);
                Dent2.gameObject.SetActive(false);
                Dent3.gameObject.SetActive(true);
                Dent4.gameObject.SetActive(false);
                break;

            case 0:
                Dent.gameObject.SetActive(false);
                Dent1.gameObject.SetActive(false);
                Dent2.gameObject.SetActive(false);
                Dent3.gameObject.SetActive(false);
                Dent4.gameObject.SetActive(true);
                //gameOver.gameObject.SetActive(true);
                Time.timeScale = 0;
            break;
        }
            
        
        if (health > slider.maxValue) health = slider.maxValue;
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

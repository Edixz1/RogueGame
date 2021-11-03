using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LolipopManBehaviourScript : MonoBehaviour
{
    private Transform player;
    private float speed = 5;
    private float rangeMoreOrLess = 1;
    
    public GameObject projectile;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        //bouger de haut en bas jusqua un collision et changer pour bas en haut
        //transform.position = Vector2.MoveTowards(transform.position, /*mystere.position*/, speed * Time.deltaTime);
        //si le joueur est a plus ou moins 1 en y du lolipop et a 
        if (player.position.y - rangeMoreOrLess <= transform.position.y && transform.position.y <= player.position.y + rangeMoreOrLess)
        {
            Vector2 difference = player.position - transform.position;
            Debug.Log(Mathf.Abs(difference.x));
            if (Mathf.Abs(difference.x) <= 10)
            {
                Debug.Log("Player in range");
                Instantiate(projectile, transform.position, Quaternion.identity);
            }
        }
    }
}

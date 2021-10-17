using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public Item item;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            PickupItem(collision);
        }
        void PickupItem(Collider2D player)
        {
            //afficher quel item a ete ramassé
            Debug.Log(item.name + " picked up");
            //prendre le script du joueur a modifier
            PlayerComponent stats = player.GetComponent<PlayerComponent>();
            //appliquer tout les changements qu'un item peut appliquer
            stats.movementSpeed *= item.speedMultiplier;
            player.transform.localScale *= item.sizeMultiplier; 
            //retirer l'item du jeu
            Destroy(gameObject);
        }
    }
}

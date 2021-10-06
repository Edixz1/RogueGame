using UnityEngine;

public class Interactable : MonoBehaviour
{
    // Start is called before the first frame update
    public float radius = 0.5f;
    public GameObject player;
    public bool hasInteracted = false;
    public float distance;

    public virtual void Interact()
    {
        // this is meant to be overwritten
        Debug.Log("interacting with " + transform.name);
    }

    void Update()
    {
        distance = Vector3.Distance(player.transform.position, transform.position);
        if (!hasInteracted)
        {
            if (distance <= radius)
            {
                Debug.Log("INTERACT");
                hasInteracted = true;
                Interact();
            }
        }
        

    }

    void OnDrawGizmosSelected() 
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, radius);
    }
}

using UnityEngine;

[CreateAssetMenu(fileName = "Nouvel Item", menuName = "Inventaire/Item")]
public class Item : ScriptableObject
{
    new public string name = "Nouvel Item";
    public Sprite icon = null;
    public bool isDefaultItem = false;
    public GameObject effect;
}


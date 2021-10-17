using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Nouvel Item", menuName = "Inventaire/Item")]
public class Item : ScriptableObject
{
    new public string name = "Nouvel Item";
    public Sprite icon = null;
    public bool isDefaultItem = false;
    /*public Dictionary<string, float> Multipliers = new Dictionary<string, float>
    {
        { "speed" , 1 },
        { "size" , 1 },
        { "bullet speed", 1 },
        { "bullet size", 1 }
    };*/

    public int maxHealthIncrease = 0;
    public int heal = 0;
    public bool allowsFlight = false;
    public float speedMultiplier = 1;
    public float sizeMultiplier = 1;
    public float bulletSpeedMultiplier = 1;
    public float bulletSizeMultiplier = 1;
    public float bulletDamage = 1;
    public float fireRateMultiplier = 1;
    

}


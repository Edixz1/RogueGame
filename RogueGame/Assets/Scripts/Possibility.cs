using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Possibility : MonoBehaviour
{
    public GameObject[] tilePossibillity;

    void Awake()
    {
        int rand = Random.Range(0, tilePossibillity.Length);
        tilePossibillity[rand].SetActive(true);
    }

}

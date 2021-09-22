using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSelectionScript : MonoBehaviour
{
    public GameObject[] Characters;
    public int selectedCharacter = 0;
    // Start is called before the first frame update
    public void NextCharacter()
    {
        Characters[selectedCharacter].SetActive(false);
        selectedCharacter = (selectedCharacter + 1) % Characters.Length;
        Characters[selectedCharacter].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

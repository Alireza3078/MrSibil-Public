using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterSelectionInGame : MonoBehaviour
{
    private GameObject[] characterList;
    private int Select;
    private void Start()
    {
        Select = PlayerPrefs.GetInt("CharacterSelected");
        characterList = new GameObject[transform.childCount];
        for (int i = 0; i < transform.childCount; i++)
            characterList[i] = transform.GetChild(i).gameObject;
        foreach (GameObject go in characterList)
            go.SetActive(false);
        if (characterList[Select])
            characterList[Select].SetActive(true);
    }
    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class CharacterSelection : MonoBehaviour
{
    private GameObject[] characterList;
    private int CharacterSelected;
    public GameObject FiroozStartBTN;
    public GameObject KhosroStartBTN;
    public GameObject FeryStartBTN;
    public GameObject HashemStartBTN;
    public GameObject KamyStartBTN;

    private void Start()
    {
        CharacterSelected = PlayerPrefs.GetInt("CharacterSelected");
        characterList = new GameObject[transform.childCount];
        for (int i = 0; i < transform.childCount; i++)
            characterList[i] = transform.GetChild(i).gameObject;
        foreach (GameObject go in characterList)
            go.SetActive(false);
        if (characterList[CharacterSelected])
            characterList[CharacterSelected].SetActive(true);
    }  
    public void toggleLeft()
    {
        characterList[CharacterSelected].SetActive(false);
        CharacterSelected--;
        if (CharacterSelected < 0)
            CharacterSelected = characterList.Length - 1;
        characterList[CharacterSelected].SetActive(true);
    }
    public void toggleRight()
    {
        characterList[CharacterSelected].SetActive(false);
        CharacterSelected++;
        if (CharacterSelected == characterList.Length)
            CharacterSelected = 0;
        characterList[CharacterSelected].SetActive(true);
    }

    public void selectchar()
    {
  
        PlayerPrefs.SetInt("CharacterSelected", CharacterSelected);
        SceneManager.LoadScene(3);
        
    }
}

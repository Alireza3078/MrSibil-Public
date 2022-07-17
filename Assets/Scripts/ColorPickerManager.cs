using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[System.Serializable]
public struct ClothsColorSet
{
    public Color ShirtColor;
    public Color PantsColor;

}

public class ColorPickerManager : MonoBehaviour
{
    [SerializeField] private string characterName = "test";
    [Space]
    [SerializeField] private ClothsColorSet[] colors;
    [SerializeField] private SpriteRenderer shirtSprite;
    [SerializeField] private SpriteRenderer astinSprite;
    [SerializeField] private SpriteRenderer pantsSprite;
    [Space]
    [SerializeField] private Button[] unlockedButtons;


    private int currentSelectedSet = 0;
    private bool[] isSetSoldList = new bool[5];

    void Start()
    {
        LoadData();
        InitButtons();
        SetMaterial(currentSelectedSet);
    }

    private void LoadData()
    {
        currentSelectedSet = PlayerPrefs.GetInt($"SetSelected{characterName}");

        for (int i = 1; i < isSetSoldList.Length; i++)
        {
            if (PlayerPrefs.HasKey($"isSet{i}Sold{characterName}"))
                isSetSoldList[i] = true;
            else
                isSetSoldList[i] = false;
        }
    }

    private void InitButtons()
    {
        for (int i = 0; i < isSetSoldList.Length; i++)
        {

            unlockedButtons[i].interactable = true;

        }
    }

    public void SetMaterial(int setID)
    {
        shirtSprite.color = colors[setID].ShirtColor;
        astinSprite.color = colors[setID].ShirtColor;
        pantsSprite.color = colors[setID].PantsColor;

        PlayerPrefs.SetInt($"SetSelected{characterName}", setID);
    }

    public void OnBuy(int buttonID)
    {

        PlayerPrefs.SetInt($"isSet{buttonID}Sold{characterName}", buttonID);
        SetMaterial(buttonID);

    }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SFXController : MonoBehaviour
{
    private SFX sfx;
    public GameObject SfxToggleIcon;
    public Sprite SfxOnSprite;
    public Sprite SfxOffSprite;

    void Start()
    {
        sfx = GameObject.FindObjectOfType<SFX>();
        UpdateIconAndVolumeSFX();
        
    }
    public void StopSFX()
    {
        sfx.ToggleSound();
        UpdateIconAndVolumeSFX();
    }
  
    public void UpdateIconAndVolumeSFX()
    {
        if (PlayerPrefs.GetInt("Muted", 0) == 0)
        {
            AudioListener.volume = 1;
            SfxToggleIcon.GetComponent<Image>().sprite = SfxOnSprite;
        }
        else
        {
            AudioListener.volume = 0;
            SfxToggleIcon.GetComponent<Image>().sprite = SfxOffSprite;
        }
    }

}

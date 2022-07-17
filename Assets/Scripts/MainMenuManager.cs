using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    public GameObject ExitPanel;
    public GameObject SettingPanel;


    public void Pressed_StartBTN()
    {
        SceneManager.LoadScene(2);
    }
    public void Pressed_ShopBTN()
    {
        SceneManager.LoadScene(2);
    }
    public void Pressed_ExitBTN()
    {
        ExitPanel.SetActive(true);
    }
    public void Pressed_SettingBTN()
    {
        SettingPanel.SetActive(true);
    }
    public void Pressed_CloseSettingPanelBTN()
    {
        SettingPanel.SetActive(false);
    }
    
}

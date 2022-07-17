using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ShopPanelManager : MonoBehaviour
{
    public GameObject CoinPanel;
    public GameObject CharacterPanel;
    public GameObject ExitBTN;
    public GameObject popupBuyCoin;

    public void CliclOnCharacterPanel()
    {
        CharacterPanel.SetActive(true);
        CoinPanel.SetActive(false);
    }
    public void ClickOnCoinPanel()
    {
        CoinPanel.SetActive(true);
        CharacterPanel.SetActive(false);
    }
   
    public void ClickOnExit()
    {
        SceneManager.LoadScene(1);
    }

    public void gotocoinpanelpopup()
    {
        CoinPanel.SetActive(true);
        CharacterPanel.SetActive(false);
        popupBuyCoin.SetActive(false);
    }
    public void ClosePopupenoughCoin()
    {
        popupBuyCoin.SetActive(false);
    }

}

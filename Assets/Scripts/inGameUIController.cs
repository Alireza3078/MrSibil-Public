using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using CoinController;

public class inGameUIController : MonoBehaviour
{
    public GameObject PausePanel;
    public GameObject GameOverPanel;
    public GameObject NavBarPanel;
    public GameObject PauseBTN_Nav;

    public void Pressed_PauseBTN()
    {
        Time.timeScale = 0;
        PausePanel.SetActive(true);
        NavBarPanel.SetActive(false);
    }
    public void Pressed_ResumeBTN()
    {
        Time.timeScale = 1;
        PausePanel.SetActive(false);
        NavBarPanel.SetActive(true);
    }
    public void Pressed_RestartBTN()
    {
        Time.timeScale = 1;
        ScoreSystem.ScoreSystem.ScoreValue = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        GameOverPanel.SetActive(false);
        SaveCoin();
    }
    public void Pressed_ExitBTN()
    {
        SceneManager.LoadScene(1);
        ScoreSystem.ScoreSystem.ScoreValue = 0;
        Time.timeScale = 1;
        SaveCoin();
    }
    public void SaveCoin()
    {
        int coins = GetMoney();
        PlayerPrefs.SetInt("MoneyAmount", CoinControll.moneyAmount);
    }
    private int GetMoney()
    {
        return PlayerPrefs.GetInt("MoneyAmount", 0);
    }
    
}

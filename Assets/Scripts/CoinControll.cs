using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace CoinController
{
    public class CoinControll : MonoBehaviour
    {

        public Text moneyText;
        public static int moneyAmount;
        void Start()
        {
            moneyAmount = PlayerPrefs.GetInt("MoneyAmount");
        }
        void Update()
        {
             moneyText.text = moneyAmount.ToString();
          //  moneyText.text = GetMoney() + "";
        }
        public void SaveCoin()
        {
            int coins = GetMoney();
            PlayerPrefs.SetInt("MoneyAmount", coins + moneyAmount );
        }

        private int GetMoney()
        {
            return PlayerPrefs.GetInt("MoneyAmount", 0);
        }

    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CoinController;


public class CoinTrigger : MonoBehaviour
{
    public AudioSource CoinSFX;
  
    private void OnTriggerEnter2D(Collider2D col)
    {       
        CoinControll.moneyAmount += 175;
        Destroy(gameObject , 0.17f);
        CoinSFX.Play();   
    }

}

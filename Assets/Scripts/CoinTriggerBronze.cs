using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CoinController;


public class CoinTriggerBronze : MonoBehaviour
{
    public AudioSource CoinSFX;

    private void OnTriggerEnter2D(Collider2D col)
    {
        CoinControll.moneyAmount += 100;
        Destroy(gameObject, 0.17f);
        CoinSFX.Play();
    }

}

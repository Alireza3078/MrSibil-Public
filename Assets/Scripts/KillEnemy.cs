using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillEnemy : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "KillEnemy") ;
        {
            CoinController.CoinControll.moneyAmount += 300;
            Destroy(gameObject);
        }
    }
}

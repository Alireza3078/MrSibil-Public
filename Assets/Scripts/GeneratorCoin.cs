using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratorCoin : MonoBehaviour
{
    public static GeneratorCoin generator;
    public GameObject CoinList;
    public GameObject[] GoldCoin;
    public GameObject[] BronzeAndSilverCoin;
    public GameObject CoinInstantiateZone;
    public int CoinPerGenerate;
    public float MaxScreenWeight;
    public float MinYDistance;
    public float MaxYDistance;
    private Vector2 pos;

    private void Awake()
    {
        generator = this;
        pos = transform.position;
        Generate();
    }
    public void Generate()
    {
        for (int i = 0; i < CoinPerGenerate; i++)
        {
            float Xpos = Random.Range(-MaxScreenWeight, MaxScreenWeight);
            float YPos = Random.Range(MinYDistance, MaxYDistance);
            pos = new Vector2(Xpos, pos.y + YPos);
            int RandomlPlatform = Random.Range(0, 2);
            GameObject CurrrentPlatform;
            if (RandomlPlatform == 1)
            {
                int LittleOrBig = Random.Range(0, BronzeAndSilverCoin.Length);
                CurrrentPlatform = BronzeAndSilverCoin[LittleOrBig];

            }
            else
            {
                int LittleOrBig = Random.Range(0, GoldCoin.Length);
                CurrrentPlatform = GoldCoin[LittleOrBig];
            }

            GameObject LastPlatform = Instantiate(CurrrentPlatform, pos, Quaternion.identity);
            LastPlatform.transform.parent = CoinList.transform;

            if (i == (CoinPerGenerate - 5))
            {
                GameObject Instantiatezone = Instantiate(CoinInstantiateZone, LastPlatform.transform.position, Quaternion.identity);
                Instantiatezone.transform.parent = CoinList.transform;
            }
        }
    }
}

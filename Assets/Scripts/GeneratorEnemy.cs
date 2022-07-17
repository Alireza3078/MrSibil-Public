using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratorEnemy : MonoBehaviour
{
    public static GeneratorEnemy generator;
    public GameObject EnemyList;
    public GameObject[] Enemy1;
    public GameObject[] Enemy2;
    public GameObject EnemyInstantiateZone;
    public int EnemyPerGenerate;
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
        for (int i = 0; i < EnemyPerGenerate; i++)
        {
            float Xpos = Random.Range(-MaxScreenWeight, MaxScreenWeight);
            float YPos = Random.Range(MinYDistance, MaxYDistance);
            pos = new Vector2(Xpos, pos.y + YPos);
            int RandomlPlatform = Random.Range(0, 2);
            GameObject CurrrentPlatform;
            if (RandomlPlatform == 1)
            {
                int LittleOrBig = Random.Range(0, Enemy2.Length);
                CurrrentPlatform = Enemy2[LittleOrBig];

            }
            else
            {
                int LittleOrBig = Random.Range(0, Enemy1.Length);
                CurrrentPlatform = Enemy1[LittleOrBig];
            }

            GameObject LastPlatform = Instantiate(CurrrentPlatform, pos, Quaternion.identity);
            LastPlatform.transform.parent = EnemyList.transform;

            if (i == (EnemyPerGenerate - 5))
            {
                GameObject Instantiatezone = Instantiate(EnemyInstantiateZone, LastPlatform.transform.position, Quaternion.identity);
                Instantiatezone.transform.parent = EnemyList.transform;
            }
        }
    }
}

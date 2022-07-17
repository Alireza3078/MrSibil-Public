using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratorOtherPlatform : MonoBehaviour
{
    public static GeneratorOtherPlatform generator;
    public GameObject OtherList;
    public GameObject[] Springs;
    public GameObject[] Breaks;
    public GameObject OtherInstantiateZone;
    public int OtherPerGenerate;
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
        for (int i = 0; i < OtherPerGenerate; i++)
        {
            float Xpos = Random.Range(-MaxScreenWeight, MaxScreenWeight);
            float YPos = Random.Range(MinYDistance, MaxYDistance);
            pos = new Vector2(Xpos, pos.y + YPos);
            int RandomlPlatform = Random.Range(0, 2);
            GameObject CurrrentPlatform;
            if (RandomlPlatform == 1)
            {
                int LittleOrBig = Random.Range(0, Breaks.Length);
                CurrrentPlatform = Breaks[LittleOrBig];

            }
            else
            {
                int LittleOrBig = Random.Range(0, Springs.Length);
                CurrrentPlatform = Springs[LittleOrBig];
            }

            GameObject LastPlatform = Instantiate(CurrrentPlatform, pos, Quaternion.identity);
            LastPlatform.transform.parent = OtherList.transform;

            if (i == (OtherPerGenerate - 5))
            {
                GameObject Instantiatezone = Instantiate(OtherInstantiateZone, LastPlatform.transform.position, Quaternion.identity);
                Instantiatezone.transform.parent = OtherList.transform;
            }
        }
    }
}

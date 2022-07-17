using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratorPlatforms : MonoBehaviour
{
    public static GeneratorPlatforms generator;
    public GameObject PlatformList;
    public GameObject[] Platfroms;
    public GameObject[] LittlePlatforms;
    public GameObject InstantiateZone;
    public int platformPerGenerate;
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
  public  void Generate()
    {
        for(int i =0; i < platformPerGenerate; i++)
        {
            float Xpos = Random.Range(-MaxScreenWeight, MaxScreenWeight);
            float YPos = Random.Range(MinYDistance, MaxYDistance);
            pos = new Vector2(Xpos, pos.y + YPos);
            int RandomlPlatform = Random.Range(0, 2);
            GameObject CurrrentPlatform;
            if (RandomlPlatform ==1)
            {
                int LittleOrBig = Random.Range(0, LittlePlatforms.Length);
                CurrrentPlatform = LittlePlatforms[LittleOrBig];
                
            }
            else
            {
                int LittleOrBig = Random.Range(0, Platfroms.Length);
                CurrrentPlatform = Platfroms[LittleOrBig];
            }
           
         GameObject LastPlatform = Instantiate(CurrrentPlatform, pos, Quaternion.identity);
            LastPlatform.transform.parent = PlatformList.transform;

            if ( i == (platformPerGenerate - 5))
            {
           GameObject Instantiatezone =  Instantiate(InstantiateZone, LastPlatform.transform.position, Quaternion.identity);
                Instantiatezone.transform.parent = PlatformList.transform;
            }
        }
    }
   
}

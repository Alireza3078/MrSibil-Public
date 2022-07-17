using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backbutton : MonoBehaviour
{
    public GameObject ExitPanel;
    void Update()
    {
        if ( Input.GetKeyDown(KeyCode.Escape))
        {
            ExitPanel
                .SetActive(true);
        }
    }
}
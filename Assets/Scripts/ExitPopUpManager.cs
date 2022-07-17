using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitPopUpManager : MonoBehaviour
{
    public GameObject ExitPanel;

    public void Pressed_YesBTN()
    {
        Application.Quit();
    }
    public void Pressed_NoBTN()
    {
        ExitPanel.SetActive(false);
    }
}

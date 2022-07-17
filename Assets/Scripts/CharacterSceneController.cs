using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CharacterSceneController : MonoBehaviour
{
    public GameObject StartBTN;
    public void ClickOnExit()
    {
        SceneManager.LoadScene(3);
    }
}

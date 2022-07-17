using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SplashController : MonoBehaviour
{
   
    public float waitTime = 0.5f;
    void Start()
    {
        StartCoroutine(GotoNextScene());
        StartCoroutine(Timeout());
    }

    IEnumerator GotoNextScene()
    {
        yield return new WaitForSeconds(waitTime);

        SceneManager.LoadScene("Main Menu");
    }

    IEnumerator Timeout()
    {
        yield return new WaitForSeconds(10);
        SceneManager.LoadScene("Main Menu");
    }
}

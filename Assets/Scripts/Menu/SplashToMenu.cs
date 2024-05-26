using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashToMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(TakeToMainMenu());
    }
    IEnumerator TakeToMainMenu()
    {
        yield return new WaitForSeconds(6f);
        SceneManager.LoadScene(1);
    }
}

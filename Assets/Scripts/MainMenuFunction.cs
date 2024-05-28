using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuFunction : MonoBehaviour
{
    [SerializeField] GameObject Fadeout;
    [SerializeField] GameObject  LoadingText;
    [SerializeField] AudioSource ButtonClickSound;
    public void OnNewGameButtonClick()
    {
        StartCoroutine(NewGame());
    }
    IEnumerator NewGame()
    {
        ButtonClickSound.Play();
        Fadeout.SetActive(true);
        yield return new WaitForSeconds(3f);
        LoadingText.SetActive(true);
        SceneManager.LoadScene(4);

    }
}

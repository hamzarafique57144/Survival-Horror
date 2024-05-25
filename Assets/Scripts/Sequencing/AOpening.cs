using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AOpening : MonoBehaviour
{
    [SerializeField] FirstPersonController Player;
    [SerializeField] GameObject FadeInScreen;
    [SerializeField] TextMeshProUGUI TextBox;
    [SerializeField] AudioSource line01;
    [SerializeField] AudioSource line02;

    private void Start()
    {
        FadeInScreen.SetActive(true);
        Player.GetComponent<FirstPersonController>().enabled = false;
        StartCoroutine(ScenePlayer());
    }

    IEnumerator ScenePlayer()
    {
        yield return new WaitForSeconds(1.5f);
        FadeInScreen.SetActive(false);
        TextBox.text = "...Where am I?";
        line01.Play();
        yield return new WaitForSeconds(2f);
        TextBox.text = " ";
        yield return new WaitForSeconds(0.5f);
        TextBox.text = "I need to get out of here!";
        line02.Play();
        yield return new WaitForSeconds(2f);
        Player.GetComponent<FirstPersonController>().enabled = true;
        TextBox.text = " ";

    }
}

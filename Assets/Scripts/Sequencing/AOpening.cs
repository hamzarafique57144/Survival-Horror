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
        TextBox.text = "I want to get out of here!";
        yield return new WaitForSeconds(2f);
        Player.GetComponent<FirstPersonController>().enabled = true;
        TextBox.text = " ";

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class IntroScene : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI textBox;
    [SerializeField] AudioSource line01;
    [SerializeField] AudioSource line02;
    [SerializeField] AudioSource line03;
    [SerializeField] AudioSource line04;
    [SerializeField] AudioSource line05;
    [SerializeField] AudioSource thudSound;
    [SerializeField] GameObject allBlack;
    [SerializeField] GameObject loadText;

    void Start()
    {
        StartCoroutine(SequenceBegin());
    }

    IEnumerator SequenceBegin()
    {
        yield return new WaitForSeconds(12);
        textBox.text = "The night of October 29th 2008 changed me forever.";
        line01.Play();
        yield return new WaitForSeconds(4.5f);
        textBox.text = "";
        yield return new WaitForSeconds(3);
        textBox.text = "I headed out to investigate the haunting sounds in the woods.";
        line02.Play();
        yield return new WaitForSeconds(5);
        textBox.text = "";
        yield return new WaitForSeconds(7);
        textBox.text = "I stumbled upon a clearing with a cabin in the distance.";
        line03.Play();
        yield return new WaitForSeconds(5);
        textBox.text = "";
        yield return new WaitForSeconds(5);
        textBox.text = "I could hear those sounds again coming from there.";
        line04.Play();
        yield return new WaitForSeconds(4);
        textBox.text = "";
        yield return new WaitForSeconds(6);
        textBox.text = "Little did I know that this was only the beginning.";
        line05.Play();
        yield return new WaitForSeconds(4);
        textBox.text = "";
        yield return new WaitForSeconds(17);
        allBlack.SetActive(true);
        thudSound.Play();
        yield return new WaitForSeconds(1);
        loadText.SetActive(true);
        SceneManager.LoadScene(2);
    }
}

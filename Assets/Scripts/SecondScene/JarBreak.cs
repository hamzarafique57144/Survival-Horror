using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JarBreak : MonoBehaviour
{
    public GameObject fakeVase;
    public GameObject brokenVase;
    public GameObject sphereObject;
    [SerializeField] AudioSource JarBreakAudio;
    [SerializeField] GameObject KeyTrigger;

   public  void DamageZombie(int DamageAmount)
    {
         
        StartCoroutine(BreakVase());
    }

    IEnumerator BreakVase()
    {

        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        fakeVase.SetActive(false);
        brokenVase.SetActive(true);
        KeyTrigger.SetActive(true);
        JarBreakAudio.Play();
        yield return new WaitForSeconds(0.05f);
        sphereObject.SetActive(true);
        yield return new WaitForSeconds(0.05f);
        sphereObject.SetActive(false);
    }


}
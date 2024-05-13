using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BFirstTrigger : MonoBehaviour
{
    [SerializeField] FirstPersonController Player;
    [SerializeField] TextMeshProUGUI TextBox;
    [SerializeField] GameObject TheMarker;
    bool PistoNotPick = true; 
    private void Update()
    {
        if(PickUpPistol.isPistolPicked == true && PistoNotPick)
        {
            this.GetComponent<BoxCollider>().enabled = false;
            PistoNotPick = false;
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            Player.GetComponent<FirstPersonController>().enabled = false;
            StartCoroutine(ScenePlayer());
        }
       
    }
    IEnumerator ScenePlayer()
    {
        TextBox.text = "Look like a weapon on that table!";
        yield return new WaitForSeconds(2.5f);
        Player.GetComponent<FirstPersonController>().enabled = true;
        TextBox.text = " ";
        TheMarker.SetActive(true);

    }
}

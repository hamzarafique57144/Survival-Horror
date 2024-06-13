using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class KeyPickUp : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI DisplayText;
    [SerializeField] TextMeshProUGUI KeyText;
    [SerializeField] float TheDistance;
    [SerializeField] GameObject ExtraCross;
    [SerializeField] GameObject KeyTrigger;
    [SerializeField] GameObject TheKey;
    bool PlayerTrigger = false;
    void Update()
    {
       if(PlayerTrigger)
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                Pick();
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            ExtraCross.SetActive(true);
            DisplayText.text = "Pick Up Key!";
            DisplayText.enabled = true;
            KeyText.enabled = true;
            PlayerTrigger = true;
            
        }
    }
    private void Pick()
    {
        
        
            
                KeyTrigger.SetActive(false);
                TheKey.SetActive(false);
                GlobalInventory.firstDoorKey = true;
                this.gameObject.GetComponent<BoxCollider>().enabled = false;
                // ActionDisplay.SetActive(false);
                DisplayText.enabled = false;
                KeyText.enabled = false;
                ExtraCross.SetActive(false);
            
        
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            ExtraCross.SetActive(false);
            //ActionDisplay.SetActive(false);
            DisplayText.enabled = false;
            KeyText.enabled = false;
            PlayerTrigger = false;
        }
    }
}

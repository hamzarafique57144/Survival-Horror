using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DoorCellOpen : MonoBehaviour
{
    public float TheDistance;
    public GameObject ActionDisplay;
    public GameObject ActionText;
    public GameObject TheDoor;
    public AudioSource CreakSound;

    private void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {

            ActionDisplay.SetActive(true);
            ActionText.SetActive(true);
            OpenDoor();
            if (Input.GetButtonDown("Action"))
            {
                Debug.Log("Action");
                ActionDisplay.SetActive(false);
                ActionText.SetActive(false);
                TheDoor.GetComponent<Animation>().Play("FirstDoorAnim");

            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            ActionDisplay.SetActive(false);
            ActionText.SetActive(false);
        }
    }
    
}

    
      
           
  


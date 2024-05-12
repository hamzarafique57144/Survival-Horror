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
    private bool isInRange = false;
    private bool isDoorOpened = false;
    [SerializeField] GameObject crossHair;
    private void Update()
    {
        if (isInRange && !isDoorOpened )
        {
            OpenDoor();
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            isInRange = true;
            
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            isInRange = false;
            ActionDisplay.SetActive(false);
            ActionText.SetActive(false);
            crossHair.SetActive(false);
        }
    }
    private void OpenDoor()
    {
        ActionDisplay.SetActive(true);
        ActionText.SetActive(true);
        crossHair.SetActive(true);

        if ( Input.GetKeyDown(KeyCode.E))
        {
            ActionDisplay.SetActive(false);
            ActionText.SetActive(false);
            crossHair.SetActive(false);
            TheDoor.GetComponent<Animation>().Play("FirstDoorAnim");
            isDoorOpened = true;
        }
            

        
    }
}

    
      
           
  


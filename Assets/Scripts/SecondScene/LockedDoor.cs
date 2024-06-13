using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LockedDoor : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI DisplayText;
    [SerializeField] TextMeshProUGUI KeyText;
    [SerializeField] float TheDistance;
    [SerializeField] GameObject ExtraCross;
    [SerializeField] AudioSource doorSound;
    [SerializeField] GameObject TheDoor;
    [SerializeField] AudioSource CreakSound;
    void Update()
    {
        TheDistance = PlayerCasting.DistanceFromTarget;
    }
    private void OnMouseOver()
    {
        if (TheDistance <= 3f)
        {

            ExtraCross.SetActive(true);
            DisplayText.text = "Open the Door!";
            DisplayText.enabled = true;
            KeyText.enabled = true;
            //  ActionDisplay.SetActive(true);


        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (TheDistance <= 3)
            {
                this.GetComponent<BoxCollider>().enabled = false;
                // ActionDisplay.SetActive(false);
                DisplayText.enabled = false;
                KeyText.enabled = false;
                ExtraCross.SetActive(false);
                StartCoroutine(ResetDoor());
            }
        }
    }
    private void OnMouseExit()
    {
        ExtraCross.SetActive(false);
        //ActionDisplay.SetActive(false);
        DisplayText.enabled = false;
        KeyText.enabled = false;
    }
    IEnumerator ResetDoor()
    {
        if(GlobalInventory.firstDoorKey==false)
        {
            doorSound.Play();
            yield return new WaitForSeconds(1);
            this.GetComponent<BoxCollider>().enabled = true;
        }
        else if(GlobalInventory.firstDoorKey == true)
        {
            TheDoor.GetComponent<Animation>().Play("Door2Anim");
            CreakSound.Play();
            yield return new WaitForSeconds(1);
            this.GetComponent<BoxCollider>().enabled = false;
        }
       

    }
}

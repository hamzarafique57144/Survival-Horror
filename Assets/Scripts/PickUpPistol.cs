using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
public class PickUpPistol : MonoBehaviour
{
    public static bool isPistolPicked=false;
    [SerializeField] GameObject FakePistol;
    [SerializeField] GameObject RealPistol;
    [SerializeField] TextMeshProUGUI DisplayText;
   // [SerializeField] GameObject ActionDisplay;
    [SerializeField] float TheDistance;
    [SerializeField] GameObject ExtraCross;
    [SerializeField] GameObject GuidArrow;
    [SerializeField] TextMeshProUGUI KeyText;
    void Update()
    {
        TheDistance = PlayerCasting.DistanceFromTarget;
    }
    private void OnMouseOver()
    {
        if(TheDistance<=3f)
        {
            
            ExtraCross.SetActive(true);
            DisplayText.text = "Pickup the Pistol!";
            DisplayText.enabled = true;
            KeyText.enabled = true;
          //  ActionDisplay.SetActive(true);
            

        }
        if(Input.GetKeyDown(KeyCode.E))
        {
            if(TheDistance <= 3)
            {
                this.GetComponent<BoxCollider>().enabled = false;
               // ActionDisplay.SetActive(false);
                DisplayText.enabled = false;
                KeyText.enabled = false;
                FakePistol.SetActive(false);
                RealPistol.SetActive(true);
                ExtraCross.SetActive(false);
                GuidArrow.SetActive(false);
                isPistolPicked = true;
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
}

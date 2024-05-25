using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmoPickUp : MonoBehaviour
{
    [SerializeField] GameObject AmoDisplayBox;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            AmoDisplayBox.SetActive(true);
            GlobalAmo.AmoCount += 7;
            this.gameObject.SetActive(false);
        }
    }
}

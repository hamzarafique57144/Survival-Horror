using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmoPickUp : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            this.gameObject.SetActive(false);
        }
    }
}

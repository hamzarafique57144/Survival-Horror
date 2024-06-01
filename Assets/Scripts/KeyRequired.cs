using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class KeyRequired : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI TextBox;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            TextBox.text = "Door is locked,you need to bring key to open the door.Key is in the jar";
            Debug.Log("Collision Enter");
        }
    }
    private void OnCollisionExit(Collision other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            TextBox.text = " ";
        }
    }
    
}

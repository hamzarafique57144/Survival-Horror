using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackingTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.CompareTag("Enemy"))
        {
            ZombieAI.attacktrigger = true;
            
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.CompareTag("Enemy"))
        {
            ZombieAI.attacktrigger = false;
        }
    }
}

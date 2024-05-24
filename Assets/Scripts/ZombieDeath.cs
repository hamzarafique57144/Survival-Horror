using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieDeath : MonoBehaviour
{
    [SerializeField] int EnemyHealth = 20;
    [SerializeField] GameObject Enemy;
    [SerializeField] int StatusCheck;
    [SerializeField] AudioSource JumpScareMusic;
   void DamageZombie(int DamageAmount)
    {
        EnemyHealth -= DamageAmount;
    }

    // Update is called once per frame
    void Update()
    {
        if(EnemyHealth <= 0 && StatusCheck == 0)
        {
            StatusCheck = 2;
            Enemy.GetComponent<Animator>().SetBool("Walk", false);
            Enemy.GetComponent<Animator>().SetTrigger("death");
            Enemy.GetComponent<BoxCollider>().enabled = false;
            JumpScareMusic.Stop();
        }
    }
}

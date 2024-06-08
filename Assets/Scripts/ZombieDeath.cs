using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ZombieDeath : MonoBehaviour
{
    [SerializeField] int EnemyHealth = 20;
    [SerializeField] GameObject Enemy;
    [SerializeField] int StatusCheck;
    [SerializeField] AudioSource JumpScareMusic;
    [SerializeField] GameObject ZombieChild;
    [SerializeField] AudioSource bgMusic;

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
            ZombieChild.GetComponent<BoxCollider>().enabled = false;
            this.GetComponent<ZombieAI>().enabled = false;
            JumpScareMusic.Stop();
            bgMusic.Play();
            StartCoroutine(LoadNextLevel());
        }
    }
   IEnumerator LoadNextLevel()
    {
        yield return new WaitForSeconds(2.3f);
        SceneManager.LoadScene(5);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ZombieAI : MonoBehaviour
{
    [SerializeField] GameObject Player;
    [SerializeField] GameObject Enemy;
    [SerializeField] float enemySpeed = 0.01f;
    public static bool attacktrigger = false;
    private bool isAtacking = false;
    private Animator animator;
    [SerializeField] AudioSource hurtSound;
    [SerializeField] AudioSource hurtSound2;
    [SerializeField] AudioSource hurtSound3;
    [SerializeField] int hurtGen;
    [SerializeField] GameObject TheFlash;
    private void Start()
    {
        animator = Enemy.GetComponent<Animator>();
    }
    private void Update()
    {
      //  Debug.Log("Attacking Trigger :" + attacktrigger);
        transform.LookAt(Player.transform);
        if(attacktrigger == false)
        {
            enemySpeed = 0.01f;
            animator.SetBool("Walk", true);
            transform.position = Vector3.MoveTowards(transform.position, Player.transform.position, enemySpeed);

        }
        if(attacktrigger == true && isAtacking == false)
        {
            enemySpeed = 0f;
            animator.SetTrigger("attack");
            StartCoroutine(InflictDamage());
        }
    }
    IEnumerator InflictDamage()
    {
        Debug.Log("Taking Damage");
        isAtacking = true;
        hurtGen = Random.Range(1, 4);
        if (hurtGen == 1)
        {
            hurtSound.Play();
        }
        else if (hurtGen == 2)
        {
            hurtSound2.Play();
        }
        else if (hurtGen == 3)
        {
            hurtSound3.Play();
        }
        hurtGen = Random.Range(1, 4);
        if (hurtGen == 1)
        {
            hurtSound.Play();
        }
        else if (hurtGen == 2)
        {
            hurtSound2.Play();
        }
        else if (hurtGen == 3)
        {
            hurtSound3.Play();
        }
        yield return new WaitForSeconds(1.1f);
        GlobalHealth.currentHealth -= 5;
        TheFlash.SetActive(true);
        yield return new WaitForSeconds(0.2f);
        TheFlash.SetActive(false);
        Debug.Log("Current Health :" + GlobalHealth.currentHealth);
        yield return new WaitForSeconds(0.9f);
        isAtacking = false;
    }
}

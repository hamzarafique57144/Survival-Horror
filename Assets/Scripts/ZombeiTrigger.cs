using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombeiTrigger : MonoBehaviour
{
    [SerializeField] AudioSource DoorBang;
    [SerializeField] AudioSource DoorjumpMusic;
    [SerializeField] GameObject Zombie;
    [SerializeField] GameObject Door;
    [SerializeField] AudioSource bgMusic;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            this.GetComponent<BoxCollider>().enabled = false;
            Door.GetComponent<Animation>().Play("Door2Anim");
            bgMusic.Stop();
            DoorBang.Play();
            Zombie.SetActive(true);
            Zombie.GetComponent<Animator>().SetBool("Walk", true);

            StartCoroutine(DoorJumpSound());
        }
    }
    IEnumerator DoorJumpSound()
    {
        yield return new WaitForSeconds(0.4f);
        DoorjumpMusic.Play();
    }
}

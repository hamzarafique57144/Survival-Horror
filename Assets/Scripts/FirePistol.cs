using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class FirePistol : MonoBehaviour
{
    [SerializeField] GameObject Gun;
    [SerializeField] GameObject Muzzle;
    [SerializeField] bool isFiring;
    [SerializeField] AudioSource GunFire;
    [SerializeField] PlayableDirector shootTimeLine;
    public float TargetDistance=25f;
    public int DamageAmount=5;

    private void Update()
    {
            if (Input.GetButtonDown("Fire1") && GlobalAmo.AmoCount != 0)
            {
            if (Gun.activeInHierarchy == true)
            {
                if (isFiring == false)
                {
                    GlobalAmo.AmoCount--;
                    StartCoroutine(FiringPistol());
                }
            }
            }
        
        
    }
    IEnumerator FiringPistol()
    {
        RaycastHit Shot;
        if(Physics.Raycast (transform.position , transform.TransformDirection(Vector3.forward), out Shot))
        {
            TargetDistance = Shot.distance;

            Shot.transform.SendMessage("DamageZombie",DamageAmount,SendMessageOptions.DontRequireReceiver);
            
        }
        isFiring = true;
        //  Gun.GetComponent<Animation>().Play("PistolShotAnimation");
        shootTimeLine.Play();
        Muzzle.SetActive(true);
        GunFire.Play();
        yield return new WaitForSeconds(0.2f);
        isFiring = false;
        Muzzle.SetActive(false);

    }
}

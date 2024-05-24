using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirePistol : MonoBehaviour
{
    [SerializeField] GameObject Gun;
    [SerializeField] GameObject Muzzle;
    [SerializeField] bool isFiring;
    [SerializeField] AudioSource GunFire;
    public float TargetDistance=25f;
    public int DamageAmount=5;

    private void Update()
    {
            if (Input.GetButtonDown("Fire1"))
            {
            if (Gun.activeInHierarchy == true)
            {
                if (isFiring == false)
                {
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
            Debug.Log("Fired");
        }
        isFiring = true;
        Gun.GetComponent<Animation>().Play("PistolShotAnimation");
        Muzzle.SetActive(true);
        GunFire.Play();
        yield return new WaitForSeconds(0.2f);
        isFiring = false;
        Muzzle.SetActive(false);

    }
}

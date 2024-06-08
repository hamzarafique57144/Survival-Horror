using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallDamaging : MonoBehaviour
{

    void DamageZombie(int DamageAmount)
    {
        Destroy(this.gameObject);
    }

}

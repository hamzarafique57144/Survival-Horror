using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GlobalInventory : MonoBehaviour
{
    public static bool firstDoorKey = false;
    bool internalDoorKey;
    // Update is called once per frame
    void Update()
    {
        internalDoorKey = firstDoorKey;
    }
}

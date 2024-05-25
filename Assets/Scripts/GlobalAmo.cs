using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GlobalAmo : MonoBehaviour
{
    public static int AmoCount;
    private int internalAmo;
    [SerializeField] TextMeshProUGUI AmoTxt;

    // Update is called once per frame
    void Update()
    {
        internalAmo = AmoCount;
        AmoTxt.text = internalAmo.ToString();
    }
}

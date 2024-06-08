using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class TorchOnOff : MonoBehaviour
{
    [SerializeField] Light torchLight;
    private void Start()
    {
        torchLight.intensity= 1.0f;
    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.F))
        {
            OnIncreaseIntensityBtnclicked();
        }
        if(Input.GetKeyDown(KeyCode.G))
        {
            OnDecreaseIntensityBtnclicked();
        }
    }
    public void OnIncreaseIntensityBtnclicked()
    {
        Debug.Log("button Clicked");
        torchLight.intensity += 2f;
        if(torchLight.intensity >= 6f)
        {
            torchLight.intensity = 6f;
        }
    }
    public void OnDecreaseIntensityBtnclicked()
    {
        torchLight.intensity -= 2f;
        if (torchLight.intensity <=0f )
        {
            torchLight.intensity = 0f;
        }
    }
}

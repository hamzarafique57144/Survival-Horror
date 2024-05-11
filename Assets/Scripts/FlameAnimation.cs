using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlameAnimation : MonoBehaviour
{
    [SerializeField] int lightMode;
    [SerializeField] GameObject flameLight;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(lightMode==0)
        {
            StartCoroutine(AnimateLight());
        }
    }
    IEnumerator AnimateLight()
    {
        lightMode = Random.Range(1, 4);
        if(lightMode==1)
        {
            flameLight.GetComponent<Animation>().Play("FlameAnim");
        }
        if (lightMode == 2)
        {
            flameLight.GetComponent<Animation>().Play("FlameAnim2");
        }
        if (lightMode == 3)
        {
            flameLight.GetComponent<Animation>().Play("FlameAnim4");
        }
        yield return new WaitForSeconds(0.99f);
        lightMode = 0;
    }
}

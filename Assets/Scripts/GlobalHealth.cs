using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GlobalHealth : MonoBehaviour
{
    public static int currentHealth=20;
    [SerializeField] private int internalHealth;
    void Update()
    {
        internalHealth = currentHealth;
        if (internalHealth <= 0)
        {
            SceneManager.LoadScene(1);
        }

    }
}

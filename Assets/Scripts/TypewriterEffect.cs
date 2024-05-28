using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class TypewriterEffect : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI uiText; 
    public float typingSpeed = 0.05f;
    [SerializeField] AudioSource TypingSound;

    
  [SerializeField]  private string fullText;

    void Start()
    {
 
        // Start the typing coroutine
        StartCoroutine(TypeText(fullText));
       
    }

    IEnumerator TypeText(string textToType)
    {
        TypingSound.Play();
        uiText.text = ""; // Clear existing text

        foreach (char letter in textToType.ToCharArray())
        {
            uiText.text += letter; // Add one letter at a time
            yield return new WaitForSeconds(typingSpeed); // Wait for a short period
           

        }
        TypingSound.Stop();
        yield return new WaitForSeconds(5.3f);
        uiText.text = " ";
    }
}

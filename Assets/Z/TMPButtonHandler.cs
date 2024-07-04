using UnityEngine;
using TMPro;


public class TMPButtonHandler : MonoBehaviour
{
    // Called when the button is clicked
    public void OnButtonClick()
    {
        // Get the TextMeshProUGUI component attached to the button
        TextMeshProUGUI buttonText = GetComponentInChildren<TextMeshProUGUI>();

        // Check if the TextMeshProUGUI component exists
        if (buttonText != null)
        {
            // Print the text of the button to the console
            Debug.Log("Button Text: " + buttonText.text);
        }
        else
        {
            Debug.LogWarning("TextMeshProUGUI component not found on the button.");
        }
    }
}

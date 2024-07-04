using UnityEngine;
using TMPro;

public class ButtonClickHandler : MonoBehaviour
{
    private string startButtonText;
    private string destButtonText;

    // Called when the start button is clicked
    public void StartButtonClicked()
    {
        // Get the text of the start button
        startButtonText = GetComponentInChildren<TextMeshProUGUI>().text.Trim();
        Debug.Log("Start Button Text: " + startButtonText);
    }

    // Called when the destination button is clicked
    public void DestinationButtonClicked()
    {
        // Ensure that startButtonText is not null or empty
        if (string.IsNullOrEmpty(startButtonText))
        {
            Debug.LogWarning("Start Button Text is null or empty.");
            return;
        }

        // Get the text of the destination button and trim whitespace
        destButtonText = GetComponentInChildren<TextMeshProUGUI>().text.Trim();
        Debug.Log("Destination Button Text: " + destButtonText);

        // Compare the button texts
        if (startButtonText == "entrance" && destButtonText == "office")
        {
            Debug.Log("Display Line");
        }
        else
        {
            Debug.Log("Start Button Text: " + startButtonText);
            Debug.Log("Destination Button Text: " + destButtonText);
            Debug.Log("Buttons have different text.");
        }
    }
}

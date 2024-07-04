using UnityEngine;
using UnityEngine.UI;

public class LineManager : MonoBehaviour
{
    public Transform destinationPoint; // Assign the destination point in the Inspector
    public LineRenderer lineRenderer; // Assign the Line Renderer component in the Inspector
    public float lineThickness = 0.1f; // Thickness of the line

    void Start()
    {
        // Disable the line renderer initially
        lineRenderer.enabled = false;

        // Set line renderer settings
        lineRenderer.startWidth = lineThickness;
        lineRenderer.endWidth = lineThickness;
    }

    public void NavigateToDestination()
    {
        // Check if the destination point is assigned
        if (destinationPoint != null)
        {
            // Enable the line renderer
            lineRenderer.enabled = true;

            // Set the starting point of the line renderer to the current position of this object
            lineRenderer.SetPosition(0, transform.position);

            // Set the end point of the line renderer to the destination point
            lineRenderer.SetPosition(1, destinationPoint.position);
        }
        else
        {
            Debug.LogError("Destination point not assigned!");
        }
    }

    public void StopNavigation()
    {
        // Disable the line renderer when called
        lineRenderer.enabled = false;
    }
}

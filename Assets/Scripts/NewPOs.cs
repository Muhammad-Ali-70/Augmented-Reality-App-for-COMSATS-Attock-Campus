using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewPOs : MonoBehaviour
{
    public LineRenderer lineRenderer;
    private Transform[] positions; // Array to hold all positions
    private int numberOfPoints; // Total number of points

    private bool isLineRendererEnabled = true; // Track the state of line renderer visibility

    // Method to populate positions array with children of the specified parent GameObject
    void PopulatePositions(GameObject parentObject)
    {
        Transform parentTransform = parentObject.transform;
        if (parentTransform.childCount > 0)
        {
            positions = new Transform[parentTransform.childCount];
            for (int i = 0; i < parentTransform.childCount; i++)
            {
                positions[i] = parentTransform.GetChild(i);
            }
            numberOfPoints = parentTransform.childCount;
        }
        else
        {
            Debug.LogWarning("No child objects found under the specified parent GameObject.");
        }
    }

    // Start is called before the first frame update
    public void SetupLineRenderer(GameObject parentObject)
    {
        PopulatePositions(parentObject);

        lineRenderer.positionCount = numberOfPoints;
    }

    // Update is called once per frame
    void Update()
    {
        // Update position count if necessary
        if (lineRenderer.positionCount != numberOfPoints)
        {
            lineRenderer.positionCount = numberOfPoints;
        }

        // Update each position
        for (int i = 0; i < numberOfPoints; i++)
        {
            lineRenderer.SetPosition(i, positions[i].position);
        }
    }

    // Method to toggle the visibility of the line renderer and its elements
    public void ToggleLineRenderer()
    {
        isLineRendererEnabled = !isLineRendererEnabled; // Toggle the state

        // Toggle the visibility of the line renderer
        lineRenderer.enabled = isLineRendererEnabled;

        // Toggle the visibility of the positions elements
        foreach (Transform position in positions)
        {
            position.gameObject.SetActive(isLineRendererEnabled);
        }
    }
}

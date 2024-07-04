using UnityEngine;

public class GeoLine : MonoBehaviour
{
    public LineRenderer lineRenderer; // Public LineRenderer variable
    public Transform parentObject; // Public reference to the parent object
    private Transform[] positions; // Array to hold all positions

    // Start is called before the first frame update
    void Start()
    {
        // Call a method to initialize positions from children of the parent object
        InitializePositions();
    }

    // Update is called once per frame
    void Update()
    {
        // Update position count if necessary
        if (lineRenderer.positionCount != positions.Length)
        {
            lineRenderer.positionCount = positions.Length;
        }

        // Update each position
        for (int i = 0; i < positions.Length; i++)
        {
            lineRenderer.SetPosition(i, positions[i].position);
        }
    }

    // Method to initialize positions from children of the parent object
    void InitializePositions()
    {
        // Check if parent object is assigned
        if (parentObject == null)
        {
            Debug.LogError("Parent object is not assigned!");
            return;
        }

        // Get all children of the parent object
        Transform[] children = parentObject.GetComponentsInChildren<Transform>();

        // Exclude the parent object itself
        positions = new Transform[children.Length - 1];

        // Populate the positions array with children
        int index = 0;
        foreach (Transform child in children)
        {
            if (child != parentObject.transform)
            {
                positions[index++] = child;
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class POS_Script : MonoBehaviour
{
    public LineRenderer lineRenderer;
    public Transform[] positions; // Array to hold all positions
    public int numberOfPoints = 3; // Total number of points

    // Start is called before the first frame update
    void Start()
    {
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
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundries : MonoBehaviour
{
    // Static variables defining the left and right boundaries of the level
    public static float leftSide = -3.5f;
    public static float rightSide = 3.5f;

    // Variables to store the internal left and right boundaries (non-static)
    public float left;
    public float right;

    // Update is called once per frame
    void Update()
    {
        // Update the internal left and right boundaries with the static values
        left = leftSide;
        right = rightSide;
    }
}

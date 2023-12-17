using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundries : MonoBehaviour
{
    public static float leftSide = -3.5f;
    public static float rightSide = 3.5f;

    // Variables to store the left and right boundaries 
    public float left;
    public float right;

    void Update()
    {
        // Update the left and right boundaries with the static values
        left = leftSide;
        right = rightSide;
    }
}

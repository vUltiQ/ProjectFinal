using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    // Rotation speed variable
    public int rotateSpeed = 1;
    
    void Update()
    {
     	// Rotate the object around the world Y-axis
     	transform.Rotate(0, rotateSpeed, 0, Space.World);  
    }
}

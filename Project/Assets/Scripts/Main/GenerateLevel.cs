using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateLevel : MonoBehaviour
{	
    public GameObject[] section;

    // Position for the new section on the Z-axis
    public int posZ = 50;

    // Flag to check if a section is currently being created
    public bool creatingSection = false;

    // Variable to store the generated section number
    public int sectionNum;

    // Update is called once per frame
    void Update()
    {
        // Check if a section is not currently being created
        if (creatingSection == false)
        {
            // Set flag to indicate that a section is being created
            creatingSection = true;

            // Start coroutine to generate a new section
            StartCoroutine(GenerateSection());
        }   
    }

    // Coroutine to generate a new section
    IEnumerator GenerateSection()
    {
        // Generate a random number to select a section from the array
        sectionNum = Random.Range(0, 3);
    	
        // Instantiate the selected section at the specified position and with no rotation
        Instantiate(section[sectionNum], new Vector3(0, 0, posZ), Quaternion.identity);
    	
        // Move the position by 40 units on the Z-axis for the next section
        posZ += 40;

        // Wait for 7 seconds before restarting the section generation process
        yield return new WaitForSeconds(7);

        // Reset the flag to indicate that a section is not being created
        creatingSection = false;
    }
}

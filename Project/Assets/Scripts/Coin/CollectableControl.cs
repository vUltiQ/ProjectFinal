using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectableControl : MonoBehaviour
{   
    // Static variable to store the total coin count 
    public static int coinCount;

    // Reference to the GameObject displaying the coin count
    public GameObject coinCountDisplay;

    void Update()
    {
        // Update the text of the coin count display with the current coin count value
        coinCountDisplay.GetComponent<TMPro.TextMeshProUGUI>().text = "" + coinCount;
    }
}

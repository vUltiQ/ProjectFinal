using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollection : MonoBehaviour
{
    // Variable to store the number of collected coins
    public int coins;

    // Called when the script instance is being loaded
    void Start()
    {
    }

    // Called when another collider enters the trigger collider attached to this object
    void OnTriggerEnter(Collider col)
    {
        // Check if the collider has the "Coin" tag
        if (col.gameObject.tag == "Coin")
        {
            // Increment the coin count and deactivate the collected coin object
            coins = coins + 1;
            col.gameObject.SetActive(false);
        }
    }

    // Method to reset the total coin count to zero
    public void ResetCoinCount()
    {
        CollectableControl.coinCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
    }
}

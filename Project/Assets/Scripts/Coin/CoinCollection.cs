using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollection : MonoBehaviour
{
    // Variable to store the number of collected coins
    public int coins;

    void Start()
    {
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Coin")
        {
            // Increment the coin count 
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

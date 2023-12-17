using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCoin : MonoBehaviour
{    
    public AudioSource CoinSFX;
    
    void OnTriggerEnter(Collider other)
    {	
        // Increase the coin count by 1 using the static variable from CollectableControl script
        CollectableControl.coinCount += 1;

        // Play the coin collection sound
        CoinSFX.Play();

        this.gameObject.SetActive(false);
    }
}

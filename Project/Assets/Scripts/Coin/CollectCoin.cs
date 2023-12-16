using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCoin : MonoBehaviour
{    
    // Reference to the audio source for the coin collection sound
    public AudioSource CoinSFX;
    
    // Called when another collider enters the trigger collider attached to this object
    void OnTriggerEnter(Collider other)
    {	
        // Increase the coin count by 1 using the static variable from CollectableControl script
        CollectableControl.coinCount += 1;

        // Play the coin collection sound
        CoinSFX.Play();

        // Deactivate the game object to visually represent the coin being collected
        this.gameObject.SetActive(false);
    }
}

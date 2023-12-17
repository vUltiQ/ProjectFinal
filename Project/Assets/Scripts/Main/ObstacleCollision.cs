using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ObstacleCollision : MonoBehaviour
{    
    public GameObject thePlayer;
    public GameObject charModel;

    // UI elements for game over screen
    public TextMeshProUGUI gameOverText;
    public Button restartButton;
    public Button mainmenuButton;

    // Audio source for collision sound
    public AudioSource CollisionSFX;

    void OnTriggerEnter(Collider other)
    {	
        this.gameObject.GetComponent<BoxCollider>().enabled = false;

        // Disable PlayerMovement script to stop player movement
        thePlayer.GetComponent<PlayerMovement>().enabled = false;

        // Play collision sound effect
        CollisionSFX.Play();

        // Trigger stumble animation on the character model
        charModel.GetComponent<Animator>().Play("Stumble Backwards");

        // Start coroutine to show game over screen after a delay
        StartCoroutine(ShowGameOverAfterDelay());
    }

    // Coroutine to show the game over screen after a delay
    IEnumerator ShowGameOverAfterDelay()
    {
        yield return new WaitForSeconds(1.5f); // 1.5-second delay

        // Activate game over text and buttons
        gameOverText.gameObject.SetActive(true);
        mainmenuButton.gameObject.SetActive(true);
        restartButton.gameObject.SetActive(true);

        // Stop the AudioSource attached to the Player GameObject
        AudioSource playerAudioSource = thePlayer.GetComponent<AudioSource>();
        if (playerAudioSource != null)
        {
            playerAudioSource.Stop();
        }
    }
}

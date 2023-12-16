using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    // Movement speed variables
    public float moveSpeed = 5;
    public float leftRightSpeed = 4;

    // Jumping variables
    public bool isJumping = false;
    public bool fallingDown = false;
    public GameObject playerObject;
    
    // Audio source for jumping sound
    public AudioSource Jumping;

    // Jumping control variables
    private bool canJump = true; 

    void Update()
    {
        // Move the player forward constantly
        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed, Space.World);
        
        // Move the player left if A or Left Arrow key is pressed and within boundaries
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            if (this.gameObject.transform.position.x > Boundries.leftSide) {
                transform.Translate(Vector3.left * Time.deltaTime * leftRightSpeed);
            }
        }
        
        // Move the player right if D or Right Arrow key is pressed and within boundaries
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            if (this.gameObject.transform.position.x < Boundries.rightSide) {
                transform.Translate(Vector3.left * Time.deltaTime * leftRightSpeed * -1);
            }
        }
        
        // Check for jump input and trigger jump
        if ((Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.Space)) && canJump)
        {
            Jump();
        } 

        // Handle vertical movement during and after jumping
        if (isJumping)
        {
            if (!fallingDown)
            {
                transform.Translate(Vector3.up * Time.deltaTime * 5, Space.World);
            }
            else
            {
                transform.Translate(Vector3.up * Time.deltaTime * -5, Space.World);
            }
        }
    }

    // Method to handle player jump
    void Jump()
    {
        if (isJumping == false)
        {
            isJumping = true;
            playerObject.GetComponent<Animator>().Play("Jump"); // Trigger jump animation
            Jumping.Play(); // Play jump sound
            StartCoroutine(JumpSequence()); // Start jump sequence coroutine
            canJump = false; // Disable jumping
            StartCoroutine(JumpCooldown(2f)); // Start cooldown coroutine
        }
    }
    
    // Coroutine for the jump sequence
    IEnumerator JumpSequence()
    {
        yield return new WaitForSeconds(0.45f);
        fallingDown = true;
        yield return new WaitForSeconds(0.45f);
        isJumping = false;
        fallingDown = false;
        playerObject.GetComponent<Animator>().Play("Running"); // Resume running animation
    }

    // Coroutine for the jump cooldown
    IEnumerator JumpCooldown(float cooldownTime)
    {
        yield return new WaitForSeconds(cooldownTime);
        canJump = true; // Enable jumping after cooldown
    }

    // Method to restart the game
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    // Method to return to the main menu
    public void MainMenu()
    {
        SceneManager.LoadScene("maain");
    }    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopJoystick : MonoBehaviour
{
    // Reference to the button that will pause the game
    public GameObject pauseButton;

    // Update is called once per frame
    void Update()
    {
        // Check if the button is clicked
        if (Input.GetButtonDown("Pause"))
        {
            // Toggle pause state
            TogglePause();
        }
    }

    // Function to toggle pause state
     public void TogglePause()
    {
        // Check if the game is currently paused
        if (Time.timeScale == 0)
        {
            // Unpause the game
            Time.timeScale = 1;
            // Activate the pause button again
            pauseButton.SetActive(true);
        }
        else
        {
            // Pause the game
            Time.timeScale = 0;
            // Deactivate the pause button
            pauseButton.SetActive(false);
        }
    }
}

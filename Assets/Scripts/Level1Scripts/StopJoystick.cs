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
        
            TogglePause();
     
    }

    // Function to toggle pause state
     public void TogglePause()
    {
        // Check if the game is currently paused
        if (Time.timeScale == 0)
        {
            // Unpause the game
            Time.timeScale = 1; 
        }
        else
        {
            // Pause the game
            Time.timeScale = 0;
        }
    }
}

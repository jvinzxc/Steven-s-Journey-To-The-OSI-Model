using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopJoystickV2 : MonoBehaviour
{
    public GameObject joystick; // Reference to your joystick object

    public Rigidbody2D rb; // Reference to the Rigidbody2D component of the character

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        // Check if the joystick is active
        if (!joystick.gameObject.activeInHierarchy)
        {
            // If joystick is inactive, stop character movement
            rb.velocity = Vector2.zero; // Stop the character's movement
        }
    }
}

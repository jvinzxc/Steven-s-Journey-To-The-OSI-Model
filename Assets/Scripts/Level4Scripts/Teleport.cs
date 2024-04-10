using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public float destinationX;
    public float destinationY;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Teleport the player to the destination position
            other.transform.position = new Vector2(destinationX, destinationY);
        }
    }
}

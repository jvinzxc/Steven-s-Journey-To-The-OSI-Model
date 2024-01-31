using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isWallActive : MonoBehaviour
{
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Walls are active!");
        }
    }
}

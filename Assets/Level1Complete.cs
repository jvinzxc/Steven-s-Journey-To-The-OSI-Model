using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1Complete : MonoBehaviour
{
    public GameObject completeSign;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            completeSign.SetActive(true);
        }
    }
}

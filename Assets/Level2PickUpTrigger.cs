using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Level2PickUpTrigger : MonoBehaviour
{
    public GameObject collectBTN;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collectBTN.SetActive(true);
        }
    }
}

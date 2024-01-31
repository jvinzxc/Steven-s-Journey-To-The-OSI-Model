using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BinaryGameTrigger : MonoBehaviour
{
    //public GameObject jstick;
    public GameObject bGame1;
    public GameObject bGameTrigger;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            bGame1.SetActive(true);
            bGameTrigger.SetActive(false);
        }
    }
}

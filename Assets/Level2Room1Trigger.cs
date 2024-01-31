using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level2Room1Trigger : MonoBehaviour
{
    public GameObject obj1;
    public GameObject room;
    public GameObject roomCollider;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (obj1.activeSelf)
            {

            }
            else
            {
                room.SetActive(false); 
                roomCollider.SetActive(false);
            }
        }
    }
}

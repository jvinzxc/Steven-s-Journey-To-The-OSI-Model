using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenFRoomLvl1 : MonoBehaviour
{
    public GameObject door1;
    public GameObject door2;
    public GameObject door3;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (door3.activeInHierarchy)
            {

            }
            else
            {
                door1.SetActive(false);
                door2.SetActive(false);
            }
            
                
        }
    }
}

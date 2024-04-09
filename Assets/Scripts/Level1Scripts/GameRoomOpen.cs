using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using UnityEngine;

public class GameRoomOpen : MonoBehaviour
{
    public GameObject room;
    public GameObject Alert;
    public GameObject door;
    public GameObject obj1;
    public GameObject obj2;
    public GameObject obj3;
    public GameObject obj4;
    public GameObject obj5;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if(obj1.activeSelf || obj2.activeSelf || obj3.activeSelf || obj4.activeSelf || obj5.activeSelf)
            {

            }
            else{
                Alert.SetActive(true);
                room.SetActive(false);
                door.SetActive(false);
            }
        }
    }
}

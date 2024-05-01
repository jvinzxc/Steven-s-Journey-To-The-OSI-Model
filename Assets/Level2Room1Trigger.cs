using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level2Room1Trigger : MonoBehaviour
{
    public GameObject obj1;
    public GameObject obj2;
    public GameObject obj3;
    public GameObject obj4;
    public GameObject obj5;

    public GameObject room;
    public GameObject roomCollider;
    public GameObject roomblock;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (!obj1.activeSelf&& obj2.activeSelf && obj3.activeSelf && obj4.activeSelf && obj5.activeSelf)
            {
                room.SetActive(false);
                roomCollider.SetActive(false);
            }
            else
            {
                
            }
        }
    }
}

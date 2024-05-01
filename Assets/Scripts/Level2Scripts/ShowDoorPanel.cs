using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowDoorPanel : MonoBehaviour
{
    public GameObject panel;

    public GameObject door;
    public GameObject door2;

    public GameObject door3;
    public GameObject door4;
    
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            panel.SetActive(true);
        }
    }

    public void OpenDoor1()
    {
        int colItems2 = PlayerPrefs.GetInt("collectedItems2");

        if(colItems2 == 5)
        {
            door.SetActive(false);
            door2.SetActive(false);
            door3.SetActive(false);
            door4.SetActive(false);
        }
    }
}

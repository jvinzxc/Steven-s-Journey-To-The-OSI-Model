using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using UnityEngine;

public class Level2Door1 : MonoBehaviour
{
    public GameObject collectBTN;
    public GameObject door1;
    public GameObject doorBlock1;
    public GameObject doorTrigger1;


    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collectBTN.SetActive(true);
            int col = PlayerPrefs.GetInt("collectedItems2");
            if(col == 5)
            {
                door1.SetActive(false);
                doorBlock1.SetActive(false);
                doorTrigger1.SetActive(false);
            }
            else
            {
                doorTrigger1.SetActive(true);
            }
        }
    }
}

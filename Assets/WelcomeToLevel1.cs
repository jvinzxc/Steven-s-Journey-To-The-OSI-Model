using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class WelcomeToLevel1 : MonoBehaviour
{
    public GameObject message;

    int levelact = 0;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            levelact++;

            if(levelact!= 2)
            {
                message.SetActive(true);
            }
        }
    }
}

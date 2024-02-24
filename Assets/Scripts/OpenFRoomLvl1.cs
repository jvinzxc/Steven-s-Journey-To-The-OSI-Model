using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenFRoomLvl1 : MonoBehaviour
{
    public GameObject door1;
    public GameObject door2;
    public GameObject door3;
    public GameObject miniGamePanel;
    public GameObject check;
    public GameObject quizGameTrigger;
    private bool activated;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (door3.activeInHierarchy)
            {
                activated = true;
            }
            else
            {
                door1.SetActive(false);
                door2.SetActive(false);
                miniGamePanel.SetActive(true);
                check.SetActive(true);
                activated = false;
            }
            
                
        }
    }

    public void Activated()
    {
        if (activated == false)
        {
            quizGameTrigger.SetActive(false);
        }
        else
        {
            quizGameTrigger.SetActive(true);
        }
    }
}

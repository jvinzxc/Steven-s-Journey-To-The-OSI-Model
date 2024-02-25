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
    public GameObject asd;
    public GameObject quizGameTrigger;
   
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            miniGamePanel.SetActive(true);

            if (check.active)
            {
                asd.SetActive(true);

                if (asd.activeInHierarchy)
                {
                    door1.SetActive(false);
                    door2.SetActive(false);
                    door3.SetActive(false);
                    quizGameTrigger.SetActive(false);
                }
            }
            else
            {
                quizGameTrigger.SetActive(true);
            }    
        }       
    }   
}

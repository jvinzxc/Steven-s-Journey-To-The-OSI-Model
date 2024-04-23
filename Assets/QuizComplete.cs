using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizComplete : MonoBehaviour
{
    public GameObject doorBlock;
    public GameObject door2;
    public GameObject doorTrigger;
    public GameObject panel;
    public GameObject asd;
    public GameObject check;
    public GameObject jstick;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            panel.SetActive(true); 
            int score = PlayerPrefs.GetInt("score");
            if (score == 10)
            {
                check.SetActive(true);
            }
            if (check.activeInHierarchy)
            {
                doorBlock.SetActive(false);
                door2.SetActive(false);
                doorTrigger.SetActive(false);

            }
            else
            {
                doorTrigger.SetActive(true);
            }

        }
    }
    public void IDK()
    {
        string done = PlayerPrefs.GetString("mgc");
        if (done == "mgc")
            {
                doorBlock.SetActive(false);
                door2.SetActive(false);
                doorTrigger.SetActive(false);
                panel.SetActive(true);
            jstick.SetActive(true);
            }
            else
            { 
                doorTrigger.SetActive(true);
                panel.SetActive(false);
                doorBlock.SetActive(true);
                door2.SetActive(true);
                jstick.SetActive(true);
            }
        
    }
}

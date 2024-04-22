using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level2QuizPanel : MonoBehaviour
{
    public GameObject quizPanel;
    public GameObject qr;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            string l2mgp2 = PlayerPrefs.GetString("l2mgp2");

            if (l2mgp2.Equals("done"))
            {
                quizPanel.SetActive(true);
            }
            else
            {
                qr.SetActive(true);
            }
        }
    }

    public void l2MinigameDone()
    {
        string l2mgp2 = "done";
        PlayerPrefs.SetString("l2mgp2", l2mgp2);
    }
}

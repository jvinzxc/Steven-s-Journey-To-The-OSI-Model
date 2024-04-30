using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level3QuizTrigger : MonoBehaviour
{
    public GameObject quizPanel;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            string l3mg = PlayerPrefs.GetString("l3mg");

            if (l3mg.Equals("done"))
            {
                quizPanel.SetActive(true);
            }

        }
    }

    public void l3MinigameDone()
    {
        string l3mg = "done";
        PlayerPrefs.SetString("l3mg", l3mg);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaveUIScript : MonoBehaviour
{

    public GameObject cave1;
    public GameObject cave2;
    public GameObject cave3;
    public GameObject cave4;

    void Start()
    {
        cave1.SetActive(true);
        cave2.SetActive(false);
        cave3.SetActive(false);
        cave4.SetActive(false);
    }
    void Update()
    {
        int score = PlayerPrefs.GetInt("l3collectedscore");

        if(score == 1)
        {
            cave1.SetActive(false);
            cave2.SetActive(true);
        }
        else if (score == 2)
        {
            cave2.SetActive(false);
            cave3.SetActive(true);
        }
        else if (score == 3)
        {
            cave3.SetActive(false);
            cave4.SetActive(true);
        }
        else if (score == 4)
        {
            cave4.SetActive(false);
        }
    }
}

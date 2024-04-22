using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level2JoystickShow : MonoBehaviour
{
    public GameObject jstick;
    void Update()
    {
        int score = PlayerPrefs.GetInt("score2");

        if (score == 10)
        {
            jstick.SetActive(true);
        } 
    }
}

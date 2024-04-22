using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level2Complete : MonoBehaviour
{
    public GameObject jstick;
    public GameObject l2Complete;
    public GameObject l2PanelComplete;

    public void Update()
    {
        string l2quiz = PlayerPrefs.GetString("l2quiz");
        if (l2quiz.Equals("done"))
        {
            l2Complete.SetActive(true);
            l2PanelComplete.SetActive(true);
            jstick.SetActive(true);
        }
        else
        {
            jstick.SetActive(true);
        }
    }
}

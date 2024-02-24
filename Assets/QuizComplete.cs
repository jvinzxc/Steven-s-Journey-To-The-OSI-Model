using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizComplete : MonoBehaviour
{
    public GameObject door;
    public GameObject doortrigger;
    public GameObject panel;
    
    public void IDK()
    {
        string quiz = PlayerPrefs.GetString("done");

        if (quiz == "done")
        {
            door.SetActive(false);
            doortrigger.SetActive(false);
            panel.SetActive(true);
        }

    }
}

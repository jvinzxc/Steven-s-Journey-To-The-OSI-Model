using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class JoystickGet : MonoBehaviour
{
    public GameObject jstick;
    QuestionManager qManager;
    private void Start()
    {
        if(qManager.score == 10)
        {
          jstick.SetActive(true);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnsScriptsLevel3 : MonoBehaviour
{
    public bool isCorrect = false;
    public QuestionManagerLevel3 qManager;
    public void Answer()
    {
        if (isCorrect)
        {
            Debug.Log("Correct Answer");

            qManager.correct();
        }
        else
        {
            Debug.Log("Wrong Answer");

            qManager.wrong();
        }
    }
}
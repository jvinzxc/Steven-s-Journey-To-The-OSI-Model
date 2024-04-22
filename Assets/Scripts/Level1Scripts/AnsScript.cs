using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnsScript : MonoBehaviour
{
    public bool isCorrect = false;
    public QuestionManager qManager;
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
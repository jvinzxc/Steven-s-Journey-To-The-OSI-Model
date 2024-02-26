using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class Level2MiniGame : MonoBehaviour
{
    public TMP_Text sampleText;
    public TMP_Text answerText;
    public Button[] btnsPrefab;
    public Button buttonUpdate;
    public Button buttonCheck;
    
    private bool pressMe;
    
    private string firstNum;
    private string secondNum;
    private string thirdNum;
    private string forthNum;
   
    private string decodedAnswer;
    public void Start()
    {
        //answerText.text = "";
    }

    public void ShowAnswer()
    {
        decodedAnswer = forthNum+thirdNum+secondNum+firstNum;
        answerText.text = decodedAnswer;
        
    }
    public void btnClick()
    {     
        for(int i = 0; i < btnsPrefab.Length; i++)
        {
            if (btnsPrefab[1])
            {
                
            }
        }
    }   
}
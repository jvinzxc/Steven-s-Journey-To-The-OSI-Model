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
    
    private bool pressMe1;
    private bool pressMe2;
    private bool pressMe3;
    private bool pressMe4;
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
        decodedAnswer = $"{forthNum}+{thirdNum}+{secondNum}+{firstNum}";
        answerText.text = decodedAnswer;
        pressMe1 = true;
        pressMe2= true;
        pressMe3= true;
        pressMe4= true;

        
    }
    public void btnClick()
    {     
        for(int i = 0; i < btnsPrefab.Length; i++)
        {
            if (btnsPrefab[0])
            {
                pressMe1 = false;
                if(pressMe1 == false)
                {
                    btnsPrefab[0].interactable = false;
                    firstNum = "1";
                }
                
            }
            else if (btnsPrefab[1])
            {
                pressMe2 = false;
                if (pressMe2 == false)
                {
                    btnsPrefab[1].interactable = false;
                    secondNum = "1";
                }

            }
            else if (btnsPrefab[2])
            {
                pressMe3 = false;
                if (pressMe3 == false)
                {
                    btnsPrefab[2].interactable = false;
                    thirdNum = "1";
                }

            }
            else if (btnsPrefab[3])
            {
                pressMe4 = false;
                if (pressMe4 == false)
                {
                    btnsPrefab[3].interactable = false;
                    forthNum = "1";
                }

            }
            else
            {
                firstNum = "0";
                secondNum= "0";
                thirdNum= "0";
                forthNum = "0";
            }
        }
    }   
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;
using System.Linq;
using UnityEditor.VersionControl;
using Unity.VisualScripting.Antlr3.Runtime.Tree;

public class Level2MiniGameV3 : MonoBehaviour
{
    public TMP_Text showText;
    public TMP_Text solveText;
    public TMP_Text messageText;
    public TMP_Text scoreText;
    public Button btn1;
    public Button btn2;
    public Button btn4;
    public Button btn8;
    public Button check;

    public List<int> toSolve;

    string btn1String;
    string btn2String;
    string btn4String;
    string btn8String;

    string result;
    int score;
    int onOff;
    
    private bool solved = false;
    void Start()
    {
        solveText.text = PlayerPrefs.GetString("result");
        score = 0;
        PlayerPrefs.SetInt("L2MGscore", score);
        scoreText.text = score.ToString();

    }

    public void Check()
    {
        int curr = PlayerPrefs.GetInt("current");
        if (curr == 0)
        {
            result = "0000";
            PlayerPrefs.SetString("result", result);
            solveText.text = result;
        }
        else if (curr == 1)
        {
            result = "0001";
            PlayerPrefs.SetString("result", result);
            solveText.text = result;
        }
        else if (curr == 2)
        {
            result = "0010";
            PlayerPrefs.SetString("result", result);
            solveText.text = result;
        }
        else if (curr == 3)
        {
            result = "0011";
            PlayerPrefs.SetString("result", result);
            solveText.text = result;
        }
        else if (curr == 4)
        {
            result = "0100";
            PlayerPrefs.SetString("result", result);
            solveText.text = result;
        }
        else if (curr == 5)
        {
            result = "0101";
            PlayerPrefs.SetString("result", result);
            solveText.text = result;
        }
        else if (curr == 6)
        {
            result = "0110";
            PlayerPrefs.SetString("result", result);
            solveText.text = result;
        }
        else if (curr == 7)
        {
            result = "0111";
            PlayerPrefs.SetString("result", result);
            solveText.text = result;
        }
        else if (curr == 8)
        {
            result = "1000";
            PlayerPrefs.SetString("result", result);
            solveText.text = result;
        }
        else if (curr == 9)
        {
            result = "1001";
            PlayerPrefs.SetString("result", result);
            solveText.text = result;
        }
        else if (curr == 10)
        {
            result = "1010";
            PlayerPrefs.SetString("result", result);
            solveText.text = result;
        }
        else if (curr == 11)
        {
            result = "1011";
            PlayerPrefs.SetString("result", result);
            solveText.text = result;
        }
        else if (curr == 12)
        {
            result = "1100";
            PlayerPrefs.SetString("result", result);
            solveText.text = result;
        }
        else if (curr == 13)
        {
            result = "1101";
            PlayerPrefs.SetString("result", result);
            solveText.text = result;
        }
        else if (curr == 14)
        {
            result = "1110";
            PlayerPrefs.SetString("result", result);
            solveText.text = result;
        }
        else if (curr == 15)
        {
            result = "1111";
            PlayerPrefs.SetString("result", result);
            solveText.text = result;
        }

        string ans = PlayerPrefs.GetString("comans");
        string prob = PlayerPrefs.GetString("result");
        if (ans.Equals(prob))
        {
            messageText.text = "Correct";
            score = PlayerPrefs.GetInt("L2MGscore");
            int sscore = score + 1;
            PlayerPrefs.SetInt("L2MGscore", sscore);
            score = PlayerPrefs.GetInt("L2MGscore");
            scoreText.text = score.ToString();
            toSolve.RemoveAt(curr);
            //if(PlayerPrefs.GetInt("L2MGscore") > 0)
            //{
            //    int sScore = PlayerPrefs.GetInt("L2MGscore") + 1;
            //    scoreText.text = "Score: " + sScore;
            //    toSolve.Remove(curr);
            //}
            solved = true;
            if(solved == true)
            {
                SolvedNext();
            }
            
            if (PlayerPrefs.GetInt("L2MGscore") == 16)
            {
                solveText.text = "Minigame Complete";
            }
        }
        else
        {
            messageText.text = "Try again";
        }

    }
    public void SolvedNext()
    {
        Calculate();
        string next = PlayerPrefs.GetString("result");
        solveText.text = next;
        int curr = PlayerPrefs.GetInt("current");
        toSolve.Remove(curr);
    }
    
    public void Calculate()
    {
        for (int i = 0; i <= toSolve.Count(); i++)
        {
            i = UnityEngine.Random.Range(0, toSolve.Count);
            PlayerPrefs.SetInt("current", i);

        }
    }

    private void Update()
    {
        btn1.onClick.AddListener(OnButtonClick);
        btn2.onClick.AddListener(OnButtonClick2);
        btn4.onClick.AddListener(OnButtonClick4);
        btn8.onClick.AddListener(OnButtonClick8);
    }

    public void OnButtonClick()
    {
        onOff = 1;
        PlayerPrefs.SetInt("onOff", onOff);
        if (onOff == 1)
        {
            PlayerPrefs.GetString("b1String");
            btn1String = "1";
            PlayerPrefs.SetString("b1String", btn1String);
            btn1.interactable = false;
        }
    }
    public void OnButtonClick2()
    {
        onOff = 1;
        PlayerPrefs.SetInt("onOff", onOff);
        if (onOff == 1)
        {
            PlayerPrefs.GetString("b2String");
            btn2String = "1";
            PlayerPrefs.SetString("b2String", btn2String);
            btn2.interactable = false;
        }
    }
    public void OnButtonClick4()
    {
        onOff = 1;
        PlayerPrefs.SetInt("onOff", onOff);
        if (onOff == 1)
        {
            PlayerPrefs.GetString("b4String");
            btn4String = "1";
            PlayerPrefs.SetString("b4String", btn4String);
            btn4.interactable = false;
        }
    }
    public void OnButtonClick8()
    {
        onOff = 1;
        PlayerPrefs.SetInt("onOff", onOff);
        if (onOff == 1)
        {
            PlayerPrefs.GetString("b8String");
            btn8String = "1";
            PlayerPrefs.SetString("b8String", btn8String);
            btn8.interactable = false;
        }
    }


    public void sendData()
    {
        PlayerPrefs.GetInt("onOff");
        onOff = 0;
        PlayerPrefs.SetInt("onOff", onOff);

        string btn1Txt = PlayerPrefs.GetString("b1String");
        string btn2Txt = PlayerPrefs.GetString("b2String");
        string btn4Txt = PlayerPrefs.GetString("b4String");
        string btn8Txt = PlayerPrefs.GetString("b8String");

        string answer = btn8Txt + btn4Txt + btn2Txt + btn1Txt;
        PlayerPrefs.SetString("comans", answer);
        showText.text = answer;

        btn1.interactable = true;
        btn2.interactable = true;
        btn4.interactable = true;
        btn8.interactable = true;
        if (btn1.interactable == true)
        {
            PlayerPrefs.GetString("b1String");
            btn1String = "0";
            PlayerPrefs.SetString("b1String", btn1String);
        }
        if (btn2.interactable == true)
        {
            PlayerPrefs.GetString("b2String");
            btn2String = "0";
            PlayerPrefs.SetString("b2String", btn2String);
        }
        if (btn4.interactable == true)
        {
            PlayerPrefs.GetString("b4String");
            btn4String = "0";
            PlayerPrefs.SetString("b4String", btn4String);
        }
        if (btn8.interactable == true)
        {
            PlayerPrefs.GetString("b8String");
            btn8String = "0";
            PlayerPrefs.SetString("b8String", btn8String);
        }

    }

}
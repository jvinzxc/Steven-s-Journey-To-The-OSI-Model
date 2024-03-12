using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Level2MiniGame : MonoBehaviour
{
    public TMP_Text playerInput;
    public TMP_Text playerToSolve;
    public TMP_Text playerScore;
    public TMP_Text playerMessage;

    public Button btn1;
    public Button btn2;
    public Button btn3;
    public Button btn4;

    private List<string> hlist = new List<string>() { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15" };
    private int score = 0;

    private bool b1;
    private bool b2;
    private bool b3;
    private bool b4;

    private string code;
    private int num_ber;
    private string b1str;
    private string b2str;
    private string b3str;
    private string b4str;
    
    public void Start()
    {
        Calculate();
        CalculatePart2();
        PlayerPrefs.SetInt("score", score);
        //playerToSolve.text = hlist[num_ber];
    }
    public void DecodeToSolve()
    {   //to be continue
        string toDecode = PlayerPrefs.GetString("code");
        string playerStr = PlayerPrefs.GetString("playerString");
        int curnum = PlayerPrefs.GetInt("num");

        if (playerStr.Equals(toDecode))
        {
            
            hlist.RemoveAt(curnum);
            playerMessage.text = "Decoded!";
            Calculate();
            CalculatePart2();
            int currScore = PlayerPrefs.GetInt("score");
            int upScore = currScore + 1;
            PlayerPrefs.SetInt("score", upScore);

            int playerScoreFinal = PlayerPrefs.GetInt("score");
            playerScore.text = playerScoreFinal.ToString();
            
            if (playerScoreFinal == 16)
            {
                playerMessage.text = "GG!";
            }
        }
        else
        {
            playerMessage.text = "Decoding error!";
        }
    }
    public void CalculatePart2()
    {
        int curnum = PlayerPrefs.GetInt("num");

        if (curnum == 0)
        {
            code = "0000";
            PlayerPrefs.SetString("code", code);
            num_ber = PlayerPrefs.GetInt("num");
            playerToSolve.text = hlist[num_ber];
        }
        else if (curnum == 1)
        {
            code = "0001";
            PlayerPrefs.SetString("code", code);
            num_ber = PlayerPrefs.GetInt("num");
            playerToSolve.text = hlist[num_ber];
        }
        else if (curnum == 2)
        {
            code = "0010";
            PlayerPrefs.SetString("code", code);
            num_ber = PlayerPrefs.GetInt("num");
            playerToSolve.text = hlist[num_ber];
        }
        else if (curnum == 3)
        {
            code = "0011";
            PlayerPrefs.SetString("code", code);
            num_ber = PlayerPrefs.GetInt("num");
            playerToSolve.text = hlist[num_ber];
        }
        else if (curnum == 4)
        {
            code = "0100";
            PlayerPrefs.SetString("code", code);
            num_ber = PlayerPrefs.GetInt("num");
            playerToSolve.text = hlist[num_ber];
        }
        else if (curnum == 5)
        {
            code = "0101";
            PlayerPrefs.SetString("code", code);
            num_ber = PlayerPrefs.GetInt("num");
            playerToSolve.text = hlist[num_ber];
        }
        else if (curnum == 6)
        {
            code = "0110";
            PlayerPrefs.SetString("code", code);
            num_ber = PlayerPrefs.GetInt("num");
            playerToSolve.text = hlist[num_ber];
        }
        else if (curnum == 7)
        {
            code = "0111";
            PlayerPrefs.SetString("code", code);
            num_ber = PlayerPrefs.GetInt("num");
            playerToSolve.text = hlist[num_ber];
        }
        else if (curnum == 8)
        {
            code = "1000";
            PlayerPrefs.SetString("code", code);
            num_ber = PlayerPrefs.GetInt("num");
            playerToSolve.text = hlist[num_ber];
        }
        else if (curnum == 9)
        {
            code = "1001";
            PlayerPrefs.SetString("code", code);
            num_ber = PlayerPrefs.GetInt("num");
            playerToSolve.text = hlist[num_ber];
        }
        else if (curnum == 10)
        {
            code = "1010";
            PlayerPrefs.SetString("code", code);
            num_ber = PlayerPrefs.GetInt("num");
            playerToSolve.text = hlist[num_ber];
        }
        else if (curnum == 11)
        {
            code = "1011";
            PlayerPrefs.SetString("code", code);
            num_ber = PlayerPrefs.GetInt("num");
            playerToSolve.text = hlist[num_ber];
        }
        else if (curnum == 12)
        {
            code = "1100";
            PlayerPrefs.SetString("code", code);
            num_ber = PlayerPrefs.GetInt("num");
            playerToSolve.text = hlist[num_ber];
        }
        else if (curnum == 13)
        {
            code = "1101";
            PlayerPrefs.SetString("code", code);
            num_ber = PlayerPrefs.GetInt("num");
            playerToSolve.text = hlist[num_ber];
        }
        else if (curnum == 14)
        {
            code = "1110";
            PlayerPrefs.SetString("code", code);
            num_ber = PlayerPrefs.GetInt("num");
            playerToSolve.text = hlist[num_ber];
        }
        else if (curnum == 15)
        {
            code = "1111";
            PlayerPrefs.SetString("code", code);
            num_ber = PlayerPrefs.GetInt("num");
            playerToSolve.text = hlist[num_ber];
        }
    }
    public void Calculate()
    {
       for (int i = 0; i < hlist.Count(); i++)
         {
            //Di nag rarandom need palitan
            int ii = Random.Range(i, hlist.Count());
            PlayerPrefs.SetInt("num", ii);
           
         }
    }
    public void SendData()
    {
        //if button not click will send 0
        if(btn1.interactable == true)
        {
            b1str = "0";
            PlayerPrefs.SetString("b1str", b1str);
        }
        if (btn2.interactable == true)
        {
            b2str = "0";
            PlayerPrefs.SetString("b2str", b2str);
        }
        if (btn3.interactable == true)
        {
            b3str = "0";
            PlayerPrefs.SetString("b3str", b3str);
        }
        if (btn4.interactable == true)
        {
            b4str = "0";
            PlayerPrefs.SetString("b4str", b4str);
        }

        //get string on each button
        string b1s = PlayerPrefs.GetString("b1str");
        string b2s = PlayerPrefs.GetString("b2str");
        string b3s = PlayerPrefs.GetString("b3str");
        string b4s = PlayerPrefs.GetString("b4str");
        
        //set string on each button to combine
        string allBtn = b4s+b3s+b2s+b1s;
        PlayerPrefs.SetString("playerString", allBtn);
        string pString = PlayerPrefs.GetString("playerString");

        //show string combined
        playerInput.text = pString;

        //set true and interactable buttons
        b1 = true;
        b2 = true;
        b3 = true;
        b4 = true;

        btn1.interactable = true;
        btn2.interactable = true;
        btn3.interactable = true;
        btn4.interactable = true;
    }
    public void Button4()
    {
        b4 = false;

        if (b4 == false)
        {
            btn4.interactable = false;
            b4str = "1";
            PlayerPrefs.SetString("b4str", b4str);
        }
    }
    public void Button3()
    {
        b3 = false;

        if (b3 == false)
        {
            btn3.interactable = false;
            b3str = "1";
            PlayerPrefs.SetString("b3str", b3str);
        }
    }
    public void Button2()
    {
        b2 = false;

        if (b2 == false)
        {
            btn2.interactable = false;
            b2str = "1";
            PlayerPrefs.SetString("b2str", b2str);
        }
    }
    public void Button1()
    {
        b1 = false;

        if(b1 == false)
        {
            btn1.interactable = false;
            b1str = "1";
            PlayerPrefs.SetString("b1str", b1str);
        }
    }
}

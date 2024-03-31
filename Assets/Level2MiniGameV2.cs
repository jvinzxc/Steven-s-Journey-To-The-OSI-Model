using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using TMPro;
using Unity.VisualScripting;
using UnityEditor.ShaderKeywordFilter;
using UnityEngine;
using UnityEngine.UI;

public class Level2MiniGameV2 : MonoBehaviour
{
    public TMP_Text playerInput;
    public TMP_Text playerToSolve;
    public TMP_Text playerScore;
    public TMP_Text playerMessage;

    public TMP_Text playerMustSolve;

    public Button btn1;
    public Button btn2;
    public Button btn3;
    public Button btn4;

    public string[] binaryList;

    private int score = 0;

    private bool b1;
    private bool b2;
    private bool b3;
    private bool b4;


    private string code;
    private string getCode;
    private string setCode;
    private int getListItem;
    private string getList;
    private string glist;

    private int num_ber;
    private string b1str;
    private string b2str;
    private string b3str;
    private string b4str;
    int fss = 0;
    
    public void Start()
    {
        RandomCalculator();

        Calculator();
    }

    public void Check()
    {
        getCode = PlayerPrefs.GetString("code");
        string getString = PlayerPrefs.GetString("playerString");
        int ranum = PlayerPrefs.GetInt("randomNum");
        string ran = ranum.ToString();
        List<string> hlist = new List<string>(binaryList);
        

        if (getString.Equals(getCode))
        {
            hlist.Remove(ran);
            int ffss = PlayerPrefs.GetInt("fs");
            int newfs = ffss + 1;
            PlayerPrefs.SetInt("fs", newfs);

            playerMessage.text = "Decoded!";
            Rerun();
        }
        else
        {
            playerMessage.text = "Try again!";
        }
    }
    public void Rerun()
    {
        RandomCalculator();
        
        Calculator();
    }

    public void Calculator()
    {
        int fs = PlayerPrefs.GetInt("fs", fss);
        int randomN = PlayerPrefs.GetInt("randomNum");
        string convertedRandomNum = randomN.ToString();
        if(convertedRandomNum == binaryList[0])
        {
            if(fs > 0)
            {
                getCode = PlayerPrefs.GetString("code");
                code.Replace(getCode, "0000");
                PlayerPrefs.SetString("code", code);
                getListItem = PlayerPrefs.GetInt("currGLI");
                getListItem = int.Parse(binaryList[0]);
                PlayerPrefs.SetInt("currGLI", getListItem);
                playerToSolve.text = randomN.ToString();
                
            }
            else
            {
                code = "0000";
                PlayerPrefs.SetString("code", code);
                getListItem = int.Parse(binaryList[0]);
                PlayerPrefs.SetInt("currGLI", getListItem);
                playerToSolve.text = randomN.ToString();
                
            }
            
        }
        else if (convertedRandomNum == binaryList[1])
        {
            if (fs > 0)
            {
                getCode = PlayerPrefs.GetString("code");
                code.Replace(getCode, "0001");
                PlayerPrefs.SetString("code", code);
                getListItem = PlayerPrefs.GetInt("currGLI");
                getListItem = int.Parse(binaryList[1]);
                PlayerPrefs.SetInt("currGLI", getListItem);
                playerToSolve.text = randomN.ToString();
                playerMustSolve.text = code.ToString();
            }
            else
            {
                code = "0001";
                PlayerPrefs.SetString("code", code);
                getListItem = int.Parse(binaryList[1]);
                PlayerPrefs.SetInt("currGLI", getListItem);
                playerToSolve.text = randomN.ToString();
                playerMustSolve.text = code.ToString();
            }
            
        }
        else if (convertedRandomNum == binaryList[2])
        {
            if (fs > 0)
            {
                getCode = PlayerPrefs.GetString("code");
                code.Replace(getCode, "0010");
                PlayerPrefs.SetString("code", code);
                getListItem = PlayerPrefs.GetInt("currGLI");
                getListItem = int.Parse(binaryList[2]);
                PlayerPrefs.SetInt("currGLI", getListItem);
                playerToSolve.text = randomN.ToString();
                playerMustSolve.text = code.ToString();
            }
            else
            {
                code = "0010";
                PlayerPrefs.SetString("code", code);
                getListItem = int.Parse(binaryList[2]);
                PlayerPrefs.SetInt("currGLI", getListItem);
                playerToSolve.text = randomN.ToString();
                playerMustSolve.text = code.ToString();
            }
        }
        else if (convertedRandomNum == binaryList[3])
        {
            if (fs > 0)
            {
                getCode = PlayerPrefs.GetString("code");
                code.Replace(getCode, "0011");
                PlayerPrefs.SetString("code", code);
                getListItem = PlayerPrefs.GetInt("currGLI");
                getListItem = int.Parse(binaryList[3]);
                PlayerPrefs.SetInt("currGLI", getListItem);
                playerToSolve.text = randomN.ToString();
                playerMustSolve.text = code.ToString();
            }
            else
            {
                code = "0011";
                PlayerPrefs.SetString("code", code);
                getListItem = int.Parse(binaryList[3]);
                PlayerPrefs.SetInt("currGLI", getListItem);
                playerToSolve.text = randomN.ToString();
                playerMustSolve.text = code.ToString();
            }
        }
        else if (convertedRandomNum == binaryList[4])
        {
            if (fs > 0)
            {
                getCode = PlayerPrefs.GetString("code");
                code.Replace(getCode, "0100");
                PlayerPrefs.SetString("code", code);
                getListItem = PlayerPrefs.GetInt("currGLI");
                getListItem = int.Parse(binaryList[4]);
                PlayerPrefs.SetInt("currGLI", getListItem);
                playerToSolve.text = randomN.ToString();
                playerMustSolve.text = code.ToString();
            }
            else
            {
                code = "0100";
                PlayerPrefs.SetString("code", code);
                getListItem = int.Parse(binaryList[4]);
                PlayerPrefs.SetInt("currGLI", getListItem);
                playerToSolve.text = randomN.ToString();
                playerMustSolve.text = code.ToString();
            }
        }
        else if (convertedRandomNum == binaryList[5])
        {
            if (fs > 0)
            {
                getCode = PlayerPrefs.GetString("code");
                code.Replace(getCode, "0101");
                PlayerPrefs.SetString("code", code);
                getListItem = PlayerPrefs.GetInt("currGLI");
                getListItem = int.Parse(binaryList[5]);
                PlayerPrefs.SetInt("currGLI", getListItem);
                playerToSolve.text = randomN.ToString();
                playerMustSolve.text = code.ToString();
            }
            else
            {
                code = "0101";
                PlayerPrefs.SetString("code", code);
                getListItem = int.Parse(binaryList[5]);
                PlayerPrefs.SetInt("currGLI", getListItem);
                playerToSolve.text = randomN.ToString();
                playerMustSolve.text = code.ToString();
            }
        }
        else if (convertedRandomNum == binaryList[6])
        {
            if (fs > 0)
            {
                getCode = PlayerPrefs.GetString("code");
                code.Replace(getCode, "0110");
                PlayerPrefs.SetString("code", code);
                getListItem = PlayerPrefs.GetInt("currGLI");
                getListItem = int.Parse(binaryList[6]);
                PlayerPrefs.SetInt("currGLI", getListItem);
                playerToSolve.text = randomN.ToString();
                playerMustSolve.text = code.ToString();
            }
            else
            {
                code = "0110";
                PlayerPrefs.SetString("code", code);
                getListItem = int.Parse(binaryList[6]);
                PlayerPrefs.SetInt("currGLI", getListItem);
                playerToSolve.text = randomN.ToString();
                playerMustSolve.text = code.ToString();
            }
        }
        else if (convertedRandomNum == binaryList[7])
        {
            if (fs > 0)
            {
                getCode = PlayerPrefs.GetString("code");
                code.Replace(getCode, "0111");
                PlayerPrefs.SetString("code", code);
                getListItem = PlayerPrefs.GetInt("currGLI");
                getListItem = int.Parse(binaryList[7]);
                PlayerPrefs.SetInt("currGLI", getListItem);
                playerToSolve.text = randomN.ToString();
                playerMustSolve.text = code.ToString();
            }
            else
            {
                code = "0111";
                PlayerPrefs.SetString("code", code);
                getListItem = int.Parse(binaryList[7]);
                PlayerPrefs.SetInt("currGLI", getListItem);
                playerToSolve.text = randomN.ToString();
                playerMustSolve.text = code.ToString();
            }
        }
        else if (convertedRandomNum == binaryList[8])
        {
            if (fs > 0)
            {
                getCode = PlayerPrefs.GetString("code");
                code.Replace(getCode, "1000");
                PlayerPrefs.SetString("code", code);
                getListItem = PlayerPrefs.GetInt("currGLI");
                getListItem = int.Parse(binaryList[8]);
                PlayerPrefs.SetInt("currGLI", getListItem);
                playerToSolve.text = randomN.ToString();
                playerMustSolve.text = code.ToString();
            }
            else
            {
                code = "1000";
                PlayerPrefs.SetString("code", code);
                getListItem = int.Parse(binaryList[8]);
                PlayerPrefs.SetInt("currGLI", getListItem);
                playerToSolve.text = randomN.ToString();
                playerMustSolve.text = code.ToString();
            }
        }
        else if (convertedRandomNum == binaryList[9])
        {
            if (fs > 0)
            {
                getCode = PlayerPrefs.GetString("code");
                code.Replace(getCode, "1001");
                PlayerPrefs.SetString("code", code);
                getListItem = PlayerPrefs.GetInt("currGLI");
                getListItem = int.Parse(binaryList[9]);
                PlayerPrefs.SetInt("currGLI", getListItem);
                playerToSolve.text = randomN.ToString();
                playerMustSolve.text = code.ToString();
            }
            else
            {
                code = "1001";
                PlayerPrefs.SetString("code", code);
                getListItem = int.Parse(binaryList[9]);
                PlayerPrefs.SetInt("currGLI", getListItem);
                playerToSolve.text = randomN.ToString();
                playerMustSolve.text = code.ToString();
            }
        }
        else if (convertedRandomNum == binaryList[10])
        {
            if (fs > 0)
            {
                getCode = PlayerPrefs.GetString("code");
                code.Replace(getCode, "1010");
                PlayerPrefs.SetString("code", code);
                getListItem = PlayerPrefs.GetInt("currGLI");
                getListItem = int.Parse(binaryList[10]);
                PlayerPrefs.SetInt("currGLI", getListItem);
                playerToSolve.text = randomN.ToString();
                playerMustSolve.text = code.ToString();
            }
            else
            {
                code = "1010";
                PlayerPrefs.SetString("code", code);
                getListItem = int.Parse(binaryList[10]);
                PlayerPrefs.SetInt("currGLI", getListItem);
                playerToSolve.text = randomN.ToString();
                playerMustSolve.text = code.ToString();
            }
        }
        else if (convertedRandomNum == binaryList[11])
        {
            if (fs > 0)
            {
                getCode = PlayerPrefs.GetString("code");
                code.Replace(getCode, "1011");
                PlayerPrefs.SetString("code", code);
                getListItem = PlayerPrefs.GetInt("currGLI");
                getListItem = int.Parse(binaryList[11]);
                PlayerPrefs.SetInt("currGLI", getListItem);
                playerToSolve.text = randomN.ToString();
                playerMustSolve.text = code.ToString();
            }
            else
            {
                code = "1011";
                PlayerPrefs.SetString("code", code);
                getListItem = int.Parse(binaryList[11]);
                PlayerPrefs.SetInt("currGLI", getListItem);
                playerToSolve.text = randomN.ToString();
                playerMustSolve.text = code.ToString();
            }
        }
        else if (convertedRandomNum == binaryList[12])
        {
            if (fs > 0)
            {
                getCode = PlayerPrefs.GetString("code");
                code.Replace(getCode, "1100");
                PlayerPrefs.SetString("code", code);
                getListItem = PlayerPrefs.GetInt("currGLI");
                getListItem = int.Parse(binaryList[12]);
                PlayerPrefs.SetInt("currGLI", getListItem);
                playerToSolve.text = randomN.ToString();
                playerMustSolve.text = code.ToString();
            }
            else
            {
                code = "1100";
                PlayerPrefs.SetString("code", code);
                getListItem = int.Parse(binaryList[12]);
                PlayerPrefs.SetInt("currGLI", getListItem);
                playerToSolve.text = randomN.ToString();
                playerMustSolve.text = code.ToString();
            }
        }
        else if (convertedRandomNum == binaryList[13])
        {
            if (fs > 0)
            {
                getCode = PlayerPrefs.GetString("code");
                code.Replace(getCode, "1101");
                PlayerPrefs.SetString("code", code);
                getListItem = PlayerPrefs.GetInt("currGLI");
                getListItem = int.Parse(binaryList[13]);
                PlayerPrefs.SetInt("currGLI", getListItem);
                playerToSolve.text = randomN.ToString();
                playerMustSolve.text = code.ToString();
            }
            else
            {
                code = "1101";
                PlayerPrefs.SetString("code", code);
                getListItem = int.Parse(binaryList[13]);
                PlayerPrefs.SetInt("currGLI", getListItem);
                playerToSolve.text = randomN.ToString();
                playerMustSolve.text = code.ToString();
            }
        }
        else if (convertedRandomNum == binaryList[14])
        {
            if (fs > 0)
            {
                getCode = PlayerPrefs.GetString("code");
                code.Replace(getCode, "1110");
                PlayerPrefs.SetString("code", code);
                getListItem = PlayerPrefs.GetInt("currGLI");
                getListItem = int.Parse(binaryList[14]);
                PlayerPrefs.SetInt("currGLI", getListItem);
                playerToSolve.text = randomN.ToString();
                playerMustSolve.text = code.ToString();
            }
            else
            {
                code = "1110";
                PlayerPrefs.SetString("code", code);
                getListItem = int.Parse(binaryList[14]);
                PlayerPrefs.SetInt("currGLI", getListItem);
                playerToSolve.text = randomN.ToString();
                playerMustSolve.text = code.ToString();
            }
        }
        else if (convertedRandomNum == binaryList[15])
        {
            if (fs > 0)
            {
                getCode = PlayerPrefs.GetString("code");
                code.Replace(getCode, "1111");
                PlayerPrefs.SetString("code", code);
                getListItem = PlayerPrefs.GetInt("currGLI");
                getListItem = int.Parse(binaryList[15]);
                PlayerPrefs.SetInt("currGLI", getListItem);
                playerToSolve.text = randomN.ToString();
                playerMustSolve.text = code.ToString();
            }
            else
            {
                code = "1111";
                PlayerPrefs.SetString("code", code);
                getListItem = int.Parse(binaryList[15]);
                PlayerPrefs.SetInt("currGLI", getListItem);
                playerToSolve.text = randomN.ToString();
                playerMustSolve.text = code.ToString();
            }
        }
    }

    public void RandomCalculator()
    {
        for(int i = 0; i < binaryList.Count(); i++)
        {
            int randomNum = Random.Range(0, binaryList.Count());
            PlayerPrefs.SetInt("randomNum", randomNum);
        }
    }

    public void SendData()
    {
        //if button not click will send 0
        if (btn1.interactable == true)
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
        string allBtn = b4s + b3s + b2s + b1s;
        PlayerPrefs.SetString("playerString", allBtn);
        string pString = PlayerPrefs.GetString("playerString");

        //show string combined
        playerInput.text = pString;
        playerMustSolve.text = PlayerPrefs.GetString("code");
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

        if (b1 == false)
        {
            btn1.interactable = false;
            b1str = "1";
            PlayerPrefs.SetString("b1str", b1str);
        }
    }
}
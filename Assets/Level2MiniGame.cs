using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Level2MiniGame : MonoBehaviour
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

    public List<string> hlist = new List<string>() { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15" };
    private int score = 0;

    private bool b1;
    private bool b2;
    private bool b3;
    private bool b4;

    
    private string code;
    private string getCode;

    private string getList;
    private string glist;

    private int num_ber;
    private string b1str;
    private string b2str;
    private string b3str;
    private string b4str;
    
    public void Start()
    {
        Rerun();
        PlayerPrefs.SetInt("score", score);
        
    }
    public void Rerun()
    {
        Calculate();
        CalculatePart2();
    }
    public void DecodeToSolve()
    {   //to be continue
        string toDecode = PlayerPrefs.GetString("code");
        string playerStr = PlayerPrefs.GetString("playerString");
        int curnum = PlayerPrefs.GetInt("num");
        getList = PlayerPrefs.GetString("glist");
        int nmbr = PlayerPrefs.GetInt("nmbr");
        if (playerStr.Equals(toDecode))
        {
            //remove decoded code
            hlist.RemoveAt(nmbr);
            

            playerMessage.text = "Decoded!";
            //new code
            Rerun();

            //firs solved!
            int fs = PlayerPrefs.GetInt("fss");
            int fsUpdate = fs + 1;
            PlayerPrefs.SetInt("fss", fsUpdate);

            int currScore = PlayerPrefs.GetInt("score");
            int upScore = currScore + 1;
            PlayerPrefs.SetInt("score", upScore);

            int playerScoreFinal = PlayerPrefs.GetInt("score");
            playerScore.text = playerScoreFinal.ToString();
            playerMustSolve.text = PlayerPrefs.GetString("code");
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
        int fs = 0;
        PlayerPrefs.SetInt("fss", fs);
        //need gumawa ng loop for number in hlist.
        int k = PlayerPrefs.GetInt("order");

        int num0 = hlist.IndexOf("0");
        int num1 = hlist.IndexOf("1");
        int num2 = hlist.IndexOf("2");
        int num3 = hlist.IndexOf("3");
        int num4 = hlist.IndexOf("4");
        int num5 = hlist.IndexOf("5");
        int num6 = hlist.IndexOf("6");
        int num7 = hlist.IndexOf("7");
        int num8 = hlist.IndexOf("8");
        int num9 = hlist.IndexOf("9");
        int num10 = hlist.IndexOf("10");
        int num11 = hlist.IndexOf("11");
        int num12 = hlist.IndexOf("12");
        int num13 = hlist.IndexOf("13");
        int num14 = hlist.IndexOf("14");
        int num15 = hlist.IndexOf("15");


        int nnum0 = 0;
        int nnum1 = 0;
        int nnum2 = 0;
        int nnum3 = 0;
        int nnum4 = 0;
        int nnum5 = 0;
        int nnum6 = 0;
        int nnum7 = 0;
        int nnum8 = 0;
        int nnum9 = 0;
        int nnum10 = 0;
        int nnum11 = 0;
        int nnum12 = 0;
        int nnum13 = 0;
        int nnum14 = 0;
        int nnum15 = 0;
        
        if (curnum == num0)
            {
                code = "0000";
                getList = PlayerPrefs.GetString("glist");
                glist = "0";
                PlayerPrefs.SetString("glist", glist);
                if (fs > 0)
                {
                    getCode = PlayerPrefs.GetString("code");
                    code.Replace(getCode, "0000");
                    PlayerPrefs.SetString("code", code);

                }
                if(nnum0 == 1)
            {
                Rerun();
            }
                
                PlayerPrefs.SetString("code", code);
                playerToSolve.text = hlist[0];
            }
            else if (curnum == num1)
            {
            PlayerPrefs.GetInt("nmbr");
            num_ber = hlist.IndexOf("1");
            PlayerPrefs.SetInt("nmbr", num_ber);

            code = "0001";
                getList = PlayerPrefs.GetString("glist");
                glist = "1";
                PlayerPrefs.SetString("glist", glist);
                if (fs > 0)
                {
                    getCode = PlayerPrefs.GetString("code");
                    code.Replace(getCode, "0001");
                    PlayerPrefs.SetString("code", code);

                    getList = PlayerPrefs.GetString("glist");
                    glist = "1";
                    PlayerPrefs.SetString("glist", glist);
                }
                PlayerPrefs.SetString("code", code);
                playerToSolve.text = hlist[1];
            }
            else if (curnum == num2)
            {
            PlayerPrefs.GetInt("nmbr");
            num_ber = hlist.IndexOf("2");
            PlayerPrefs.SetInt("nmbr", num_ber);

            code = "0010";
                getList = PlayerPrefs.GetString("glist");
                glist = "2";
                PlayerPrefs.SetString("glist", glist);
                if (fs > 0)
                {
                    getCode = PlayerPrefs.GetString("code");
                    code.Replace(getCode, "0010");
                    PlayerPrefs.SetString("code", code);

                }
                PlayerPrefs.SetString("code", code);
                playerToSolve.text = hlist[2];
            }
            else if (curnum == num3)
            {
            PlayerPrefs.GetInt("nmbr");
            num_ber = hlist.IndexOf("3");
            PlayerPrefs.SetInt("nmbr", num_ber);
            code = "0011";
                getList = PlayerPrefs.GetString("glist");
                glist = "3";
                PlayerPrefs.SetString("glist", glist);
                if (fs > 0)
                {
                    getCode = PlayerPrefs.GetString("code");
                    code.Replace(getCode, "0011");
                    PlayerPrefs.SetString("code", code);
                }
                PlayerPrefs.SetString("code", code);
                playerToSolve.text = hlist[3];
            }
            else if (curnum == num4)
            {
            PlayerPrefs.GetInt("nmbr");
            num_ber = hlist.IndexOf("4");
            PlayerPrefs.SetInt("nmbr", num_ber);
            code = "0100";
                getList = PlayerPrefs.GetString("glist");
                glist = "4";
                PlayerPrefs.SetString("glist", glist);
                if (fs > 0)
                {
                    getCode = PlayerPrefs.GetString("code");
                    code.Replace(getCode, "0100");
                    PlayerPrefs.SetString("code", code);
                }
                PlayerPrefs.SetString("code", code);
                playerToSolve.text = hlist[4];
            }
            else if (curnum == num5)
            {
            PlayerPrefs.GetInt("nmbr");
            num_ber = hlist.IndexOf("5");
            PlayerPrefs.SetInt("nmbr", num_ber);
            code = "0101";
                getList = PlayerPrefs.GetString("glist");
                glist = "5";
                PlayerPrefs.SetString("glist", glist);
                if (fs > 0)
                {
                    getCode = PlayerPrefs.GetString("code");
                    code.Replace(getCode, "0101");
                    PlayerPrefs.SetString("code", code);
                }
                PlayerPrefs.SetString("code", code);
                playerToSolve.text = hlist[5];
            }
            else if (curnum == num6)
            {
            PlayerPrefs.GetInt("nmbr");
            num_ber = hlist.IndexOf("6");
            PlayerPrefs.SetInt("nmbr", num_ber);
            code = "0110";
                getList = PlayerPrefs.GetString("glist");
                glist = "6";
                PlayerPrefs.SetString("glist", glist);
                if (fs > 0)
                {
                    getCode = PlayerPrefs.GetString("code");
                    code.Replace(getCode, "0110");
                    PlayerPrefs.SetString("code", code);
                }
                PlayerPrefs.SetString("code", code);
                playerToSolve.text = hlist[6];
            }
            else if (curnum == num7)
            {
            PlayerPrefs.GetInt("nmbr");
            num_ber = hlist.IndexOf("6");
            PlayerPrefs.SetInt("nmbr", num_ber);
            code = "0111";
                getList = PlayerPrefs.GetString("glist");
                glist = "7";
                PlayerPrefs.SetString("glist", glist);
                if (fs > 0)
                {
                    getCode = PlayerPrefs.GetString("code");
                    code.Replace(getCode, "0111");
                    PlayerPrefs.SetString("code", code);
                }
                PlayerPrefs.SetString("code", code);
                playerToSolve.text = hlist[7];
            }
            else if (curnum == num8)
            {
            PlayerPrefs.GetInt("nmbr");
            num_ber = hlist.IndexOf("8");
            PlayerPrefs.SetInt("nmbr", num_ber);
            code = "1000";
                getList = PlayerPrefs.GetString("glist");
                glist = "8";
                PlayerPrefs.SetString("glist", glist);
                if (fs > 0)
                {
                    getCode = PlayerPrefs.GetString("code");
                    code.Replace(getCode, "1000");
                    PlayerPrefs.SetString("code", code);
                }
                PlayerPrefs.SetString("code", code);
                playerToSolve.text = hlist[8];
            }
            else if (curnum == num9)
            {
            PlayerPrefs.GetInt("nmbr");
            num_ber = hlist.IndexOf("9");
            PlayerPrefs.SetInt("nmbr", num_ber);
            code = "1001";
                getList = PlayerPrefs.GetString("glist");
                glist = "9";
                PlayerPrefs.SetString("glist", glist);
                if (fs > 0)
                {
                    getCode = PlayerPrefs.GetString("code");
                    code.Replace(getCode, "1001");
                    PlayerPrefs.SetString("code", code);
                }
                PlayerPrefs.SetString("code", code);
                playerToSolve.text = hlist[9];
            }
            else if (curnum == num10)
            {
            PlayerPrefs.GetInt("nmbr");
            num_ber = hlist.IndexOf("10");
            PlayerPrefs.SetInt("nmbr", num_ber);
            code = "1010";
                getList = PlayerPrefs.GetString("glist");
                glist = "10";
                PlayerPrefs.SetString("glist", glist);
                if (fs > 0)
                {
                    getCode = PlayerPrefs.GetString("code");
                    code.Replace(getCode, "1010");
                    PlayerPrefs.SetString("code", code);
                }
                PlayerPrefs.SetString("code", code);
                playerToSolve.text = hlist[10];
            }
            else if (curnum == num11)
            {
            PlayerPrefs.GetInt("nmbr");
            num_ber = hlist.IndexOf("11");
            PlayerPrefs.SetInt("nmbr", num_ber);
            code = "1011";
                getList = PlayerPrefs.GetString("glist");
                glist = "11";
                PlayerPrefs.SetString("glist", glist);
                if (fs > 0)
                {
                    getCode = PlayerPrefs.GetString("code");
                    code.Replace(getCode, "1011");
                    PlayerPrefs.SetString("code", code);
                }
                PlayerPrefs.SetString("code", code);
                playerToSolve.text = hlist[11];
            }
            else if (curnum == num12)
            {
            PlayerPrefs.GetInt("nmbr");
            num_ber = hlist.IndexOf("12");
            PlayerPrefs.SetInt("nmbr", num_ber);
            code = "1100";
                getList = PlayerPrefs.GetString("glist");
                glist = "12";
                PlayerPrefs.SetString("glist", glist);
                if (fs > 0)
                {
                    getCode = PlayerPrefs.GetString("code");
                    code.Replace(getCode, "1100");
                    PlayerPrefs.SetString("code", code);
                }
                PlayerPrefs.SetString("code", code);
                playerToSolve.text = hlist[12];
            }
            else if (curnum == num13)
            {
            PlayerPrefs.GetInt("nmbr");
            num_ber = hlist.IndexOf("13");
            PlayerPrefs.SetInt("nmbr", num_ber);
            code = "1101";
                getList = PlayerPrefs.GetString("glist");
                glist = "13";
                PlayerPrefs.SetString("glist", glist);
                if (fs > 0)
                {
                    getCode = PlayerPrefs.GetString("code");
                    code.Replace(getCode, "1101");
                    PlayerPrefs.SetString("code", code);
                }
                PlayerPrefs.SetString("code", code);
                playerToSolve.text = hlist[13];
            }
            else if (curnum == num14)
            {
            PlayerPrefs.GetInt("nmbr");
            num_ber = hlist.IndexOf("14");
            PlayerPrefs.SetInt("nmbr", num_ber);
            code = "1110";
                getList = PlayerPrefs.GetString("glist");
                glist = "14";
                PlayerPrefs.SetString("glist", glist);
                if (fs > 0)
                {
                    getCode = PlayerPrefs.GetString("code");
                    code.Replace(getCode, "1110");
                    PlayerPrefs.SetString("code", code);
                }
                PlayerPrefs.SetString("code", code);
                playerToSolve.text = hlist[14];
            }
            else if (curnum == num15)
            {
            PlayerPrefs.GetInt("nmbr");
            num_ber = hlist.IndexOf("15");
            PlayerPrefs.SetInt("nmbr", num_ber);
            code = "1111";
                getList = PlayerPrefs.GetString("glist");
                glist = "15";
                PlayerPrefs.SetString("glist", glist);
                if (fs > 0)
                {
                    getCode = PlayerPrefs.GetString("code");
                    code.Replace(getCode, "1111");
                    PlayerPrefs.SetString("code", code);
                }
                PlayerPrefs.SetString("code", code);
                playerToSolve.text = hlist[15];
            }
        
    }
    public void Calculate()
    {  
            int ii = Random.Range(0, hlist.Count());
            PlayerPrefs.SetInt("num", ii);

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

        if(b1 == false)
        {
            btn1.interactable = false;
            b1str = "1";
            PlayerPrefs.SetString("b1str", b1str);
        }
    }
}

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

    public List<int> hlist = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

    private int score = 0;

    private bool b1;
    private bool b2;
    private bool b3;
    private bool b4;


    private string code;
    private string getCode;
    private int getListItem;
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
        int currGLI = PlayerPrefs.GetInt("currGLI");
        if (playerStr.Equals(toDecode))
        {
            //remove decoded code
            hlist.Remove(currGLI);


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

    public void CalculatePart3()
    {
        string code2 = PlayerPrefs.GetString("code");
    }
    public void CalculatePart2()
    {
        int curnum = PlayerPrefs.GetInt("num");
        int fs = 0;
        PlayerPrefs.SetInt("fss", fs);
        //need gumawa ng loop for number in hlist.
        int k = PlayerPrefs.GetInt("order");

        for (int i = 0; i < hlist.Count(); i++)
        {
            if (curnum == hlist[0])
            {
                //code  main property
                code = "0000";
                getList = PlayerPrefs.GetString("glist");
                glist = "0";
                PlayerPrefs.SetString("glist", glist);
                //code needed for first time solving
                if (fs > 0)
                {
                    getCode = PlayerPrefs.GetString("code");
                    code.Replace(getCode, "0000");
                    PlayerPrefs.SetString("code", code);
                }
                PlayerPrefs.SetString("code", code);
                //code need to remove current number in the list
                PlayerPrefs.GetString("currGLI");
                getListItem = hlist[0];
                PlayerPrefs.SetInt("currGLI", getListItem);
                //print only
                playerToSolve.text = hlist[0].ToString();
            }
            else if (curnum == 1)
            {
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
                PlayerPrefs.GetInt("currGLI");
                getListItem = hlist[1];
                PlayerPrefs.SetInt("currGLI", getListItem);
                playerToSolve.text = hlist[1].ToString();
            }
            else if (curnum == 2)
            {
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
                PlayerPrefs.GetInt("currGLI");
                getListItem = hlist[2];
                PlayerPrefs.SetInt("currGLI", getListItem);
                playerToSolve.text = hlist[2].ToString();
            }
            else if (curnum == 3)
            {
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
                PlayerPrefs.GetInt("currGLI");
                getListItem = hlist[3];
                PlayerPrefs.SetInt("currGLI", getListItem);
                playerToSolve.text = hlist[3].ToString();
            }
            else if (curnum == 4)
            {
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
                PlayerPrefs.GetInt("currGLI");
                getListItem = hlist[4];
                PlayerPrefs.SetInt("currGLI", getListItem);
                playerToSolve.text = hlist[4].ToString();
            }
            else if (curnum == 5)
            {
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
                PlayerPrefs.GetInt("currGLI");
                getListItem = hlist[5];
                PlayerPrefs.SetInt("currGLI", getListItem);
                playerToSolve.text = hlist[5].ToString();
            }
            else if (curnum == 6)
            {

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
                PlayerPrefs.GetInt("currGLI");
                getListItem = hlist[6];
                PlayerPrefs.SetInt("currGLI", getListItem);
                playerToSolve.text = hlist[6].ToString();
            }
            else if (curnum == 7)
            {

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
                PlayerPrefs.GetInt("currGLI");
                getListItem = hlist[7];
                PlayerPrefs.SetInt("currGLI", getListItem);
                playerToSolve.text = hlist[7].ToString();
            }
            else if (curnum == 8)
            {

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
                PlayerPrefs.GetInt("currGLI");
                getListItem = hlist[8];
                PlayerPrefs.SetInt("currGLI", getListItem);
                playerToSolve.text = hlist[8].ToString();
            }
            else if (curnum == 9)
            {

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
                PlayerPrefs.GetInt("currGLI");
                getListItem = hlist[9];
                PlayerPrefs.SetInt("currGLI", getListItem);
                playerToSolve.text = hlist[9].ToString();
            }
            else if (curnum == 10)
            {

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
                PlayerPrefs.GetInt("currGLI");
                getListItem = hlist[10];
                PlayerPrefs.SetInt("currGLI", getListItem);
                playerToSolve.text = hlist[10].ToString();
            }
            else if (curnum == 11)
            {

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
                PlayerPrefs.GetInt("currGLI");
                getListItem = hlist[11];
                PlayerPrefs.SetInt("currGLI", getListItem);
                playerToSolve.text = hlist[11].ToString();
            }
            else if (curnum == 12)
            {

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
                PlayerPrefs.GetInt("currGLI");
                getListItem = hlist[12];
                PlayerPrefs.SetInt("currGLI", getListItem);
                playerToSolve.text = hlist[12].ToString();
            }
            else if (curnum == 13)
            {

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
                PlayerPrefs.GetInt("currGLI");
                getListItem = hlist[13];
                PlayerPrefs.SetInt("currGLI", getListItem);
                playerToSolve.text = hlist[13].ToString();
            }
            else if (curnum == 14)
            {

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
                PlayerPrefs.GetInt("currGLI");
                getListItem = hlist[14];
                PlayerPrefs.SetInt("currGLI", getListItem);
                playerToSolve.text = hlist[14].ToString();
            }
            else if (curnum == 15)
            {

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
                PlayerPrefs.GetInt("currGLI");
                getListItem = hlist[15];
                PlayerPrefs.SetInt("currGLI", getListItem);
                playerToSolve.text = hlist[15].ToString();
            }
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

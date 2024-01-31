using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConvertMiniGameScript : MonoBehaviour
{

    public Text text11;
    public Text text12;
    public Text text13;
    public Text text14;
    public Text text15;
    public Text text16;

    public InputField inf1;
    public InputField inf2;
    public InputField inf3;
    public InputField inf4;
    public InputField inf5;
    public InputField inf6;

    public void ConvertMiniGame()
    {
        string playerAnswer1 = inf1.text;
        string playerAnswer2 = inf2.text;
        string playerAnswer3 = inf3.text;
        string playerAnswer4 = inf4.text;
        string playerAnswer5 = inf5.text;
        string playerAnswer6 = inf6.text;

        if (playerAnswer1 == "B4")
        {
            text11.text = "B4 is correct!";
        }
        else
        {
            text11.text = "Wrong Answer!";
            
        }

        if (playerAnswer2 == "2E")
        {
            text12.text = "2E is correct!";
            
        }
        else
        {
            text12.text = "Wrong Answer!";
        }
        
        if (playerAnswer3 == "99")
        {
            text13.text = "99 is correct!";

        }
        else
        {
            text13.text = "Wrong Answer!";
        }
     
        if (playerAnswer4 == "EA")
        {
            text14.text = "EA is correct!";

        }
        else
        {
            text14.text = "Wrong Answer!";
        }
        
        if (playerAnswer5 == "73")
        {
            text15.text = "73 is correct!";

        }
        else
        {
            text15.text = "Wrong Answer!";
        }
        
        if (playerAnswer6 == "4A")
        {
            text16.text = "4A is correct!";

        }
        else
        {
            text16.text = "Wrong Answer!";
        }
   
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class L2MGamePart2 : MonoBehaviour
{
    public TMP_Text questionText;
    public TMP_InputField answerInput;
    public TMP_Text resultText;
    public TMP_Text answerInputShow;
    public TMP_Text score;
    public Button nextButton;
    public GameObject panel2;
    public List<string> binaryNumbers = new List<string>();
    private string hexadecimalNumber;
    private int scr = 0;

    // Start is called before the first frame update
    void Start()
    {
        GenerateQuestion();
        resultText.text = " ";
        score.text = "Player Score: 0";
    }

    // Generate a random binary number and set up the question text
    void GenerateQuestion()
    {
        if (binaryNumbers.Count == 0)
        {
            resultText.text = "You've completed all questions!";
            nextButton.interactable = false;
            return;
        }

        int randomIndex = Random.Range(0, binaryNumbers.Count);
        string binaryNumber = binaryNumbers[randomIndex];
        binaryNumbers.RemoveAt(randomIndex);
        int decimalNumber = System.Convert.ToInt32(binaryNumber, 2); // Convert binary to decimal
        hexadecimalNumber = decimalNumber.ToString("X"); // Convert decimal to hexadecimal
        questionText.text = "Convert " + binaryNumber + " to hexadecimal:";
        answerInput.text = "";
    }
    public void Update()
    {
        if (scr == 16)
        {
            panel2.SetActive(true);
            
        }
    }
   
    // Check the player's answer
    public void CheckAnswer()
    {
        string playerAnswer = PlayerPrefs.GetString("ans");
        if (playerAnswer == hexadecimalNumber)
        {
            resultText.text = "Correct!";
            GenerateQuestion();
            if(scr == 0)
            {
                scr = 1;
            }
            else if (scr > 0)
            {
                scr++;
            }
            string scr2 = scr.ToString();
            score.text = "Player Score: " + scr2;
         
        }
        else
        {
            resultText.text = "Incorrect answer. Try Again!";
        }
    }

    // Called when the "Next" button is clicked
    public void NextQuestion()
    {
        string ans = answerInput.text.ToUpper();
        answerInputShow.text = ans;
        PlayerPrefs.SetString("ans", ans);
    }
}

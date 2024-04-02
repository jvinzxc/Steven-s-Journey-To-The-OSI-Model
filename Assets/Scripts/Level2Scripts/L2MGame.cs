using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class L2MGame : MonoBehaviour
{
    public TMP_Text questionText;
    public TMP_InputField answerInput;
    public TMP_Text resultText;
    public Button nextButton;
    public TMP_Text answerInputShow;
    public TMP_Text score;
    public GameObject panel2;
    public List<int> decimalNumbers = new List<int>();
    private string binaryNumber;
    private int scr = 0;


    // Start is called before the first frame update
    void Start()
    {
        GenerateQuestion();
        answerInputShow.text = "No data received";
        resultText.text = " ";
        score.text = "Player Score: 0";
    }

    // Generate a random decimal number and set up the question text
    void GenerateQuestion()
    {
        if (decimalNumbers.Count == 0)
        {
            resultText.text = "You've completed all questions!";
            nextButton.interactable = false;
            return;
        }

        int randomIndex = Random.Range(0, decimalNumbers.Count);
        int decimalNumber = decimalNumbers[randomIndex];
        decimalNumbers.RemoveAt(randomIndex);
        binaryNumber = System.Convert.ToString(decimalNumber, 2); // Convert decimal to binary
        questionText.text = "Convert " + decimalNumber + " to binary:";
        answerInput.text = "";
    }
    private void Update()
    {
      if(scr == 16)
        {
            panel2.SetActive(true);
        }
    }
    // Check the player's answer
    public void CheckAnswer()
    {
        string playerAnswer = PlayerPrefs.GetString("ans");
        if (playerAnswer == binaryNumber)
        {
            resultText.text = "Correct!";
            GenerateQuestion();
            if (scr == 0)
            {
                scr = 1;
                score.text = "Player Score: " + scr.ToString();
            }
            else if (scr > 0)
            {
                scr++;
                score.text = "Player Score: " + scr.ToString();
            }
            
        }
        else
        {
            resultText.text = "Incorrect answer. Try Again!";
        }
    }

    // Called when the "Next" button is clicked
    public void NextQuestion()
    {
        string ansText = answerInput.text.Trim();
        answerInputShow.text = ansText;
        PlayerPrefs.SetString("ans", ansText);

    }
}

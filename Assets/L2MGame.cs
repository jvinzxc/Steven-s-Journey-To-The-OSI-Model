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

    public List<int> decimalNumbers = new List<int>();
    private string binaryNumber;

    
    // Start is called before the first frame update
    void Start()
    {
        GenerateQuestion();
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
        resultText.text = "";
        answerInput.text = "";
    }

    // Check the player's answer
    public void CheckAnswer()
    {
        string playerAnswer = answerInput.text.Trim();
        if (playerAnswer == binaryNumber)
        {
            resultText.text = "Correct!";
            GenerateQuestion();
        }
        else
        {
            resultText.text = "Incorrect. The correct answer is " + binaryNumber + ".";
        }
    }

    // Called when the "Next" button is clicked
    public void NextQuestion()
    {
        GenerateQuestion();
    }
}

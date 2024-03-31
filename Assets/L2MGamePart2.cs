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
    public Button nextButton;
    public List<string> binaryNumbers = new List<string>();
    private string hexadecimalNumber;

    // Start is called before the first frame update
    void Start()
    {
        GenerateQuestion();
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
        resultText.text = "";
        answerInput.text = "";
    }

    // Check the player's answer
    public void CheckAnswer()
    {
        string playerAnswer = answerInput.text.Trim().ToUpper();
        if (playerAnswer == hexadecimalNumber)
        {
            resultText.text = "Correct!";
            GenerateQuestion();
        }
        else
        {
            resultText.text = "Incorrect. The correct answer is " + hexadecimalNumber + ".";
        }
    }

    // Called when the "Next" button is clicked
    public void NextQuestion()
    {
        GenerateQuestion();
    }
}

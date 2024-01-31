using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BinaryGameController : MonoBehaviour
{
    public Text binaryText;
    public InputField userInput;
    public Text resultText;
    public GameObject prevBGame;
    public GameObject nextBGame;
    private int score = 0;
    private int decimalNumber;

    void Start()
    {
        GenerateRandomBinary();
    }

    void GenerateRandomBinary()
    {
        decimalNumber = Random.Range(1, 64); // Generates a random decimal number between 1 and 63
        string binaryRepresentation = System.Convert.ToString(decimalNumber, 2);
        binaryText.text = "Binary: " + binaryRepresentation;
    }

    public void CheckAnswer()
    {
        string userAnswer = userInput.text;

        if (userAnswer == System.Convert.ToString(decimalNumber))
        {
            score++;
            resultText.text = "Correct!";
            if(score == 1)
            {
                nextBGame.SetActive(true);
                prevBGame.SetActive(false);
            }
        }
        else
        {
            resultText.text = "Try again!";
        }

        // Generate a new random binary number
        GenerateRandomBinary();
        userInput.text = ""; // Clear input field
    }

}

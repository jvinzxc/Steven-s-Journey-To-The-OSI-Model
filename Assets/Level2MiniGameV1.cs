using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Level2MiniGameV1 : MonoBehaviour
{
    public TMP_Text binaryText;
    public TMP_Text selectedButtonText;
    public TMP_Text scoreText;
    public TMP_Text resultText; // New Text element to display the result message

    private List<string> binaryQuestions = new List<string> { "0000", "0001", "0010", "0011", "0100", "0101", "0110", "0111", "1000", "1001", "1010", "1011", "1100", "1101", "1110", "1111" };
    private List<string> binaryTextsForDisplay = new List<string>();
    private int currentQuestionIndex;
    private int score;
    private string currentBinaryQuestion;
    private string currentSelectedBinary; // Store the current selected binary

    public void Start()
    {
        // Initialize game
        currentQuestionIndex = Random.Range(0, binaryQuestions.Count);
        SetBinaryQuestion(currentQuestionIndex);
        score = 0;
        UpdateScoreText();
    }

    public void ButtonClicked(int value)
    {
        // Handle button clicks
        // Toggle binary digits based on button values (1, 2, 4, 😎
        // Example: If button 1 is clicked, binaryText.text = "1"
        // Example: If button 2 is clicked, binaryText.text = "10", and so on

        // Update the selected button text
        selectedButtonText.text += value.ToString();

        // Update the current selected binary
        currentSelectedBinary = selectedButtonText.text;
    }

    public void SendData()
    {
        // Check if the entered binary value matches the current question
        if (binaryText.text == currentBinaryQuestion)
        {
            // Show a message or perform an action to indicate correct answer
            resultText.text = "Correct answer! Binary sent: " + currentSelectedBinary;
        }
        else
        {
            // Show a message or perform an action to indicate wrong answer
            resultText.text = "Wrong answer. Try again!";
        }
    }

    public void CheckData()
    {
        // Submit the current answer
        if (binaryText.text == currentBinaryQuestion)
        {
            // Update score if the answer is correct
            score++;
            UpdateScoreText();

            // Remove the current question and proceed to the next one
            binaryQuestions.RemoveAt(currentQuestionIndex);
            binaryTextsForDisplay.RemoveAt(currentQuestionIndex);
            if (binaryQuestions.Count > 0)
            {
                currentQuestionIndex = Random.Range(0, binaryQuestions.Count);
                SetBinaryQuestion(currentQuestionIndex);
            }
            else
            {
                // Game Over
                Debug.Log("Game Over");
            }
        }
        else
        {
            // Show a message or perform an action to indicate that the user needs to answer correctly first
            resultText.text = "Answer correctly first before sending!";
        }
    }

    private void SetBinaryQuestion(int index)
    {
        // Set the current binary question
        currentBinaryQuestion = binaryQuestions[index];
        binaryText.text = currentBinaryQuestion;
        selectedButtonText.text = "";
        currentSelectedBinary = ""; // Reset the current selected binary
    }

    private void UpdateScoreText()
    {
        scoreText.text = "Score: " + score;
    }
}

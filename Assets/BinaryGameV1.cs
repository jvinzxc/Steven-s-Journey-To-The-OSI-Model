using System;
using System.Linq;
using System.Text;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UI;



public class BinaryGameV1 : MonoBehaviour
{
    public Text binaryText;
    public Text letterText;
    public InputField answerInput;
    public Text resultText;

    // Define an array of words to solve
    public string[] wordsToSolve = { "UNITY", "C#", "GAME", "DEVELOPMENT", "BINARY" };

    private void Start()
    {
        // Start the game by choosing a random word and converting it to binary
        GenerateRandomBinary();
    }

    public void CheckAnswer()
    {
        // Check if the player's answer is correct
        string playerAnswer = answerInput.text.Trim();
        string correctAnswer = BinaryToLetters(binaryText.text);

        if (playerAnswer.ToUpper() == correctAnswer.ToUpper())
        {
            DisplayGuessWords();
            if (wordsToSolve.Length == 0)
            {
            resultText.text = "Congratulations! Your answer is correct.";
            }
            
        }
        else
        {
            resultText.text = "Sorry, your answer is incorrect. Try again.";
        }
    }
    private void DisplayGuessWords()
    {
        foreach(string word in wordsToSolve)
        {
            for(int i=0; i < wordsToSolve.Length; i++)
            {
                letterText.text = wordsToSolve[i];

            }
            
        }
    }

    private void GenerateRandomBinary()
    {
        // Choose a random word from the array
        string randomWord = wordsToSolve[UnityEngine.Random.Range(0, wordsToSolve.Length)];

        // Convert the word to binary
        string binaryString = WordToBinary(randomWord);

        // Display the binary string to the player
        binaryText.text = $"Binary: {binaryString}";

        // Clear the previous result text
        resultText.text = "";

        // Clear the answer input field
        answerInput.text = "";
    }

    private string WordToBinary(string word)
    {
       
        StringBuilder binaryStringBuilder = new StringBuilder();
        foreach (char c in word)
        {
            binaryStringBuilder.Append(Convert.ToString(c, 2).PadLeft(8, '0'));
        }

        return binaryStringBuilder.ToString();
    }

    private string BinaryToLetters(string binary)
    {
        // Convert a binary string to letters (characters)
        StringBuilder letterStringBuilder = new StringBuilder();

        for (int i = 0; i < binary.Length; i += 8)
        {
            string binarySubstring = binary.Substring(i, Mathf.Min(8, binary.Length - i));

            if (binarySubstring.Length == 8)
            {
                try
                {
                    int charCode = Convert.ToInt32(binarySubstring, 2);
                    char character = (char)charCode;
                    letterStringBuilder.Append(character);
                }
                catch (FormatException)
                {
                    // Handle the exception if conversion fails
                    Debug.LogError($"Invalid binary substring: {binarySubstring}");
                }
            }
        }

        return letterStringBuilder.ToString();
    }

    public void GenerateNewBinary()
    {
        // Generate a new random binary string when the player wants to try again
        GenerateRandomBinary();
    }
}
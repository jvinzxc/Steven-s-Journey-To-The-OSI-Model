using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Controller : MonoBehaviour
{
    [SerializeField]

    private TMP_Text targetNumberText;
    private int targetNumber;
    private Calculator calculator;

    private void Awake()
    {
        calculator = FindObjectOfType<Calculator>();
    }

    private void ChooseNewNumber()
    {
        targetNumber = Random.Range(0, 255);
        targetNumberText.text = targetNumber.ToString();
    }
    void Update()
    {
        if (calculator.Total == targetNumber)
        {
            ChooseNewNumber();
        }
    }
}

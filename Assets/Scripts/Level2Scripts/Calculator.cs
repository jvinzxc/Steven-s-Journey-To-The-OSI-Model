using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Calculator : MonoBehaviour
{
    private Text TotalText;
    public int Total {get; private set; }
    private void Start()
    {
        var allToggles = FindObjectsOfType<Level2MiniGameV1>();
        foreach (var toggle in allToggles)
        toggle.OnToggleChanged += Toggle_OnToggleChanged;
    }

    private void Toggle_OnToggleChanged(int number, bool enabled)
    {
        if(enabled)
        {
            Total += number;

        }
        else
        {
            Total += number;

        }
        TotalText.text = Total.ToString();
    }
}

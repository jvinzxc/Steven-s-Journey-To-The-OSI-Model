using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class LevelManager : MonoBehaviour
{
    int levelsUnlocked;
    public Button[] buttons;
    public TMP_Text text;
    
    void Start()
    {
        levelsUnlocked = PlayerPrefs.GetInt("levelsUnlocked");

        
        for(int i=0; i <buttons.Length; i++)
        {
            buttons[i].interactable = false;
        }

        for(int i = 0; i < levelsUnlocked; i++)
        {
            if(levelsUnlocked == 1)
            {
                buttons[i].interactable = true;
            }
            if (levelsUnlocked == 2)
            {
                buttons[i].interactable = true;
            }
            if (levelsUnlocked == 3)
            {
                buttons[i].interactable = true;
            }
            if(levelsUnlocked == 4)
            {
                buttons[i].interactable = true;
            }
            if(levelsUnlocked == 5)
            {
                buttons[i].interactable = true;
            }
            if(levelsUnlocked == 6)
            {
                buttons[i].interactable = true;
            }
        }
    }

    public void LoadLevel()
    {
        int level = PlayerPrefs.GetInt("levelsUnlocked", 0);
        text.text = "current Level is " + level + " !!! ";
    }
}

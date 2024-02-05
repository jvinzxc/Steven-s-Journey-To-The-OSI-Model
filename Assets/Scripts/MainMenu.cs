using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    
    public void PlayGame()
    {
        //PlayerPrefs mo lagay ka
        SceneManager.LoadScene("LoadingScene");
    }
    public void QuitGame()
    {
        Debug.Log("GAME STOPPED!");
        Application.Quit();
        
    }
}

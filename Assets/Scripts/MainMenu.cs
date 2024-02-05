using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public void PlayGame()
    {
        string sceneName = "House";
        PlayerPrefs.SetString("SceneName", sceneName);
        SceneManager.LoadScene("LoadingScene");
    }
    public void QuitGame()
    {
        Debug.Log("GAME STOPPED!");
        Application.Quit();
        
    }
}

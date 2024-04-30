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

    public void HouseDoneUnlocked()
    {

        int levelsUnlocked = 1;
        PlayerPrefs.SetInt("levelsUnlocked", levelsUnlocked);
        bool houseDone = true;

        if(houseDone == true)
        {
            int updatedlvl = PlayerPrefs.GetInt("levelsUnlocked");
            PlayerPrefs.SetInt("levelsUnlocked", updatedlvl);
        }
    }

    public void GotoMainMenu()
    {
        string sceneName = "Menu";
        PlayerPrefs.SetString("SceneName", sceneName);
        SceneManager.LoadScene("LoadingScene");
    }
    public void LevelLoader()
    {
        string sceneName = "LevelChoices";
        PlayerPrefs.SetString("SceneName", sceneName);
        SceneManager.LoadScene("LoadingScene");
    }
    public void Level1()
    {
        string sceneName = "Level 1";
        PlayerPrefs.SetString("SceneName", sceneName);
        SceneManager.LoadScene("LoadingScene");
    }
    public void Level1Quiz()
    {
        string sceneName = "Quiz";
        PlayerPrefs.SetString("SceneName", sceneName);
        SceneManager.LoadSceneAsync("Quiz", LoadSceneMode.Additive);
    }
    public void Level1QuizDone()
    {
        PlayerPrefs.GetString("done");
    }

    public void Level2()
    {
        string sceneName = "Level 2";
        PlayerPrefs.SetString("SceneName", sceneName);
        SceneManager.LoadScene("LoadingScene");
    }
    public void Level2Quiz()
    {
        string sceneName = "Quiz 2";
        PlayerPrefs.SetString("SceneName", sceneName);
        SceneManager.LoadSceneAsync("Quiz 2", LoadSceneMode.Additive);
    }
    public void Level2QuizDone()
    {
        string l2mgp2 = "done";
        PlayerPrefs.SetString("l2mgp2", l2mgp2);
    }

    public void Level3()
    {
        string sceneName = "Level 3";
        PlayerPrefs.SetString("SceneName", sceneName);
        SceneManager.LoadScene("LoadingScene");
    }
    public void Level3Quiz()
    {
        string sceneName = "Quiz 3";
        PlayerPrefs.SetString("SceneName", sceneName);
        SceneManager.LoadSceneAsync("Quiz 3", LoadSceneMode.Additive);
    }
    public void Level3QuizDone()
    {
        string l3mg = "done";
        PlayerPrefs.SetString("l3mg", l3mg);
    }

    public void Level4()
    {
        string sceneName = "Level 4";
        PlayerPrefs.SetString("SceneName", sceneName);
        SceneManager.LoadScene("LoadingScene");
    }

    public void Level5()
    {
        string sceneName = "Level 5";
        PlayerPrefs.SetString("SceneName", sceneName);
        SceneManager.LoadScene("LoadingScene");
    }

    public void Level6()
    {
        string sceneName = "Level 6";
        PlayerPrefs.SetString("SceneName", sceneName);
        SceneManager.LoadScene("LoadingScene");
    }
    public void Level7()
    {
        string sceneName = "Level 7";
        PlayerPrefs.SetString("SceneName", sceneName);
        SceneManager.LoadScene("LoadingScene");
    }

    public void Level1Done()
    {
        string sceneName = "LevelChoices";
        int currentLevel = 2;
        PlayerPrefs.SetString("SceneName", sceneName);
        PlayerPrefs.SetInt("levelsUnlocked", currentLevel);
        SceneManager.LoadScene("LoadingScene");
    }
    public void Level2Done()
    {
        string sceneName = "LevelChoices";
        int currentLevel = 3;
        PlayerPrefs.SetString("SceneName", sceneName);
        PlayerPrefs.SetInt("levelsUnlocked", currentLevel);
        SceneManager.LoadScene("LoadingScene");
    }

    public void Level3Done()
    {
        string sceneName = "LevelChoices";
        int currentLevel = 4;
        PlayerPrefs.SetString("SceneName", sceneName);
        PlayerPrefs.SetInt("levelsUnlocked", currentLevel);
        SceneManager.LoadScene("LoadingScene");
    }

    public void Level4Done()
    {
        string sceneName = "LevelChoices";
        int currentLevel = 5;
        PlayerPrefs.SetString("SceneName", sceneName);
        PlayerPrefs.SetInt("levelsUnlocked", currentLevel);
        SceneManager.LoadScene("LoadingScene");
    }

    public void Level5Done()
    {
        string sceneName = "LevelChoices";
        int currentLevel = 6;
        PlayerPrefs.SetString("SceneName", sceneName);
        PlayerPrefs.SetInt("levelsUnlocked", currentLevel);
        SceneManager.LoadScene("LoadingScene");
    }

    public void Level6Done()
    {
        string sceneName = "LevelChoices";
        int currentLevel = 7;
        PlayerPrefs.SetString("SceneName", sceneName);
        PlayerPrefs.SetInt("levelsUnlocked", currentLevel);
        SceneManager.LoadScene("LoadingScene");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Linq;
using TMPro;


public class SceneList : MonoBehaviour
{
    public TMP_Text loadingText; // Reference to a UI Text component to display loading progress

    public void LoadLoadingScene(string nextScene)
    {
        SceneManager.LoadSceneAsync(nextScene);
        StartCoroutine(LoadSceneAsync(nextScene));
    }

    private IEnumerator LoadSceneAsync(string sceneToLoad)
    {
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(sceneToLoad);
        asyncLoad.allowSceneActivation = false;

        float timer = 6f;

        while (!asyncLoad.isDone)
        {
            timer += Time.deltaTime;

            if (asyncLoad.progress >= 0.9f)
            {
                loadingText.text = "Loading... 100%";
                asyncLoad.allowSceneActivation = true;
                
            }
            else
            {
                loadingText.text = "Loading... " + Mathf.FloorToInt(asyncLoad.progress * 100) + "%";
            }

            yield return null;
        }
    }

    // This function will be called when a button in the Main Menu is clicked
    public void LoadNextScene(string nextScene)
    {
        LoadLoadingScene(nextScene);
    }
}
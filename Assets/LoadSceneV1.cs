using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
using UnityEditor.SceneManagement;

public class LoadSceneV1 : MonoBehaviour
{
    public GameObject loadingScene;
    public Slider slider;
    public TMP_Text text;
    private Scene prevScene;
    public void Start()
    {
       Scene prevScene = SceneManager.GetActiveScene();
  
        if(prevScene.buildIndex == 1)
        {
            loadsceneAsync(prevScene.buildIndex);
            Invoke("LoadSceneWithIndex", 6f);
        }
        
    }

    public void LoadSceneWithIndex()
    {
        SceneManager.LoadSceneAsync(2);
        SceneManager.UnloadSceneAsync(1);

        
    }

    public void LoadScene(int sceneId)
    {
        StartCoroutine(loadsceneAsync(sceneId));
    }
    IEnumerator loadsceneAsync(int sceneId)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneId);

        loadingScene.SetActive(true);
        while (!operation.isDone)
        {
            if (operation.progress <= 0.9f)
            {
                text.text = "Loading " + Mathf.FloorToInt(operation.progress * 100) + "%";
                yield return new WaitForSeconds(6f);

                operation.allowSceneActivation = true;

            }
            else
            {
                text.text = "Loading " + Mathf.FloorToInt(operation.progress * 100) + "%";
            }

            float progressValue = Mathf.Clamp01(operation.progress / 0.9f);
            slider.value = progressValue;

            yield return null;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadingSceneV2 : MonoBehaviour
{

    public GameObject loadingScene;
    public Slider slider;
    public void LoadScene(int levelIndex)
    {
        StartCoroutine(loadsceneAsync(levelIndex));
    }
    IEnumerator loadsceneAsync(int levelIndex)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(levelIndex);
        loadingScene.SetActive(true);
        while (!operation.isDone)
        {

            slider.value = operation.progress;
            yield return null;
        }
    }
}

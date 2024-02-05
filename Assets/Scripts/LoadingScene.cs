using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadingScene : MonoBehaviour
{
    public GameObject loadingScreen;
    public Slider slider;

    
    private void Start()
    {
        StartCoroutine(LoadAsync());
    }

    private IEnumerator LoadAsync()
    {
        slider.value = 0;
        loadingScreen.SetActive(true);
        
        string sceneName = PlayerPrefs.GetString("sceneName");

        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneName);
        operation.allowSceneActivation = false;
        float progress = 0;

        while (!operation.isDone)
        {
            progress = Mathf.MoveTowards(progress, operation.progress, Time.deltaTime);
            slider.value = progress;
            if (progress >= 0.9f)
            {
                slider.value = 1;
                operation.allowSceneActivation = true;
            }
            yield return null;
        }
    }
   
}

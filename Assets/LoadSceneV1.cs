using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
using UnityEditor.SceneManagement;

public class LoadSceneV1 : MonoBehaviour
{
    public TextMeshProUGUI loadingText;
    public Slider slider;

    private void Start(){
        StartCoroutine(LoadSceneAsync());
    }
    
    private IEnumerator LoadSceneAsync()
    {
        AsyncOperation operation;
        slider.value = 0;
        float progress = 0;

        string sceneName = PlayerPrefs.GetString("SceneName"); 
        operation = SceneManager.LoadSceneAsync(sceneName);

        operation.allowSceneActivation = false;

        while (!operation.isDone)
        {
            progress = Mathf.MoveTowards(progress, operation.progress, Time.deltaTime);
            slider.value = progress;

            if (progress >= 0.9f)
            {
                slider.value = 1;

                //pagexperimentuhan mo
                loadingText.text = "Loading " + Mathf.FloorToInt(operation.progress * 100) + "%";
                yield return new WaitForSeconds(3f);

                operation.allowSceneActivation = true;

            }
            else
            {
                loadingText.text = "Loading " + Mathf.FloorToInt(operation.progress * 100) + "%";
            }

            //float progressValue = Mathf.Clamp01(operation.progress / 0.9f);
            //slider.value = progressValue;

            yield return null;
        }
    }
}

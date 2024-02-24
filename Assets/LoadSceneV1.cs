using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
using UnityEditor.SceneManagement;
using Unity.VisualScripting;

public class LoadSceneV1 : MonoBehaviour
{
    public TMP_Text loadingText;
    public Slider slider;

    private void Start(){
        StartCoroutine(LoadSceneAsync());
    }
    
    private void Update()
    {

    }
    private IEnumerator LoadSceneAsync()
    {
        AsyncOperation operation;
        string sceneName = PlayerPrefs.GetString("SceneName"); 
        operation = SceneManager.LoadSceneAsync(sceneName);
        operation.allowSceneActivation = false;

        while (!operation.isDone)
        {
            //progress = Mathf.MoveTowards(progress, operation.progress, Time.deltaTime);
            float progressValue = Mathf.Clamp01(operation.progress / 0.9f);
            slider.value = progressValue;

            if (progressValue >= 0.9f)
           {
                
                //pagexperimentuhan mo
                loadingText.text = "Loading " + Mathf.FloorToInt(slider.value * 100) + "%";
        

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

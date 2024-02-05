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
    public Scene menu;

    private void Start(){
        StartCoroutine(LoadSceneAsync());
    }
    /* Ginawa ko munang comment
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
    }*/
    private IEnumerator LoadSceneAsync()
    {
        //AsyncOperation operation = SceneManager.LoadSceneAsync(sceneId);
        /*Pwede mo to gamitin pag ipapasa mo ung scene name, for example Level 1, Level 2(Ayusin mo sa stage choices ung logic, Sa ngayon fix ko muna)
        string sceneName = PlayerPrefs.GetString("SceneName"); //Pede ka gumamit ng PlayerPrefs na nagpapalit("Level1", "Level2" etc..) kada ibang stage pinipindot
        operation = SceneManager.LoadSceneAsync(sceneName);*/


        //House muna siya for now, para makita natin if working
        AsyncOperation operation = SceneManager.LoadSceneAsync("House");

        operation.allowSceneActivation = false;

        while (!operation.isDone)
        {
            if (operation.progress >= 0.9f)
            {
                loadingText.text = "Loading " + Mathf.FloorToInt(operation.progress * 100) + "%";
                yield return new WaitForSeconds(6f);

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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
using System.IO;

public class Loading : MonoBehaviour
{
    public TextMeshProUGUI loadingText;
    
    void Start()
    {
        StartCoroutine(LoadMainGameScene(loadingText));

    }

    private IEnumerator LoadMainGameScene(Text loadingText)
    {
        AsyncOperation operation;
        
        if (SceneManager.GetActiveScene().Equals("Menu"))
        {
            operation = SceneManager.LoadSceneAsync(2);
        }
        else if (SceneManager.GetActiveScene().Equals("House"))
        {
            operation = SceneManager.LoadSceneAsync(3);
            
        }
        while (!operation.isDone)
        {
            if (operation.progress >= 0.9f)
            {
                loadingText.text = "Loading " + Mathf.FloorToInt(operation.progress * 100) + "%";
                yield return new WaitForSeconds(6f);
            }
            else
            {
                loadingText.text = "Loading " + Mathf.FloorToInt(operation.progress * 100) + "%";
            }

            yield return null;
        }
        
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}

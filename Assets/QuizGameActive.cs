using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuizGameActive : MonoBehaviour
{
    public GameObject js;
    public GameObject boxHide;
    public GameObject boxShow;

    int counter;
    QuestionManager questionManager;
    
    void Start()
    {
        
    }

    public void Clicked()
    {
        counter++;
        UpdateClick();
        loadSc();
    }

    public void loadSc()
    {
        SceneManager.LoadScene(4, LoadSceneMode.Additive);
    }

    public void UpdateClick()
    {
            if(counter % 1 == 0)
            {
                js.SetActive(false);
                boxShow.SetActive(false);
                boxHide.SetActive(true);

            }
            if (counter % 2 == 0)
            {
                if(questionManager.score == 10)
            {
                js.SetActive(true);
            }
            }
    }
}

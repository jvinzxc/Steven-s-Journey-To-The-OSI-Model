using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;
using UnityEngine.Assertions.Must;
using Unity.VisualScripting;

public class QuestionManager : MonoBehaviour
{
    public List<QuestionAndAnswer> qna;
    public GameObject[] options;
    public int currentQuestions;
    public Text questionText;
    public Text scoreText;
    public GameObject questionPanel;
    public GameObject goPanel;
    public GameObject goPanel2;
    public GameObject goPanel2Text;
    public GameObject jstick;
    public Text gpText2;
    int totalQuestion;
    public int score;
    public Text retryText;
 
    public void Start()
    {
       
        QuestionManager questionManager= this;
        totalQuestion = qna.Count;
        goPanel.SetActive(false);
        genQuestion();    

    }
   
    public void retry()
    {
        SceneManager.UnloadSceneAsync(4);

    }
    
    public void GameOver()
    {
        if (score == 10)
        {
            questionPanel.SetActive(false);
            goPanel.SetActive(true);
            scoreText.text = score + "/" + totalQuestion;
            retryText.text = "Back";
            StartCoroutine(myCoroutine());
            
           
        }
        else
        {
            questionPanel.SetActive(false);
            goPanel2.SetActive(true);
            gpText2.text = score + "/" + totalQuestion;
            StartCoroutine(myCoroutine());
            
        }
            
    }

    IEnumerator myCoroutine()
    {
        yield return new WaitForSeconds(6f);
    }
    public void correct()
    {
        score += 1;
        qna.RemoveAt(currentQuestions);
        genQuestion();
    }

    public void wrong()
    {
        qna.RemoveAt(currentQuestions);
        genQuestion();
    }

    public void setAnswer()
    {
        for (int i = 0; i < options.Length; i++)
        {
            options[i].GetComponent<AnsScript>().isCorrect = false;
            options[i].transform.GetChild(0).GetComponent<Text>().text = qna[currentQuestions].answer[i];
            if (qna[currentQuestions].correctAnswer == i + 1)
            {
                options[i].GetComponent<AnsScript>().isCorrect = true;
            }
        }
    }

    void genQuestion()
    {
         if (qna.Count != 0)
         {
                currentQuestions = Random.Range(0, qna.Count);
                questionText.text = qna[currentQuestions].question;
                setAnswer();
         }
         else
         {
                
                Debug.Log("Out of Question");
                GameOver();
         } 
    }
}
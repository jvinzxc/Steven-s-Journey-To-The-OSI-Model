using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;
using UnityEngine.Assertions.Must;
using Unity.VisualScripting;
using TMPro;

public class QuestionManager : MonoBehaviour
{
    public List<QuestionAndAnswer> qna;
    public GameObject[] options;
    public int currentQuestions;
    public Text questionText;
    public GameObject questionPanel;
    int totalQuestion;
    public int score = 0;

    public GameObject quiz1;
    public GameObject quizRetry;
    public TMP_Text playerScore1;
    public TMP_Text playerScore2;
    public TMP_Text messageDone1;
    public TMP_Text messageDone2;

    
    
    public void Start()
    {
       
        QuestionManager questionManager= this;
        totalQuestion = qna.Count;
        quiz1.SetActive(false);
        genQuestion();    

    }
   
    public void retry()
    {
        SceneManager.UnloadSceneAsync("Quiz");
        SceneManager.LoadSceneAsync("Quiz", LoadSceneMode.Additive);

    }
    public void GameOver()
    {
        if (score == 10)
        {
            questionPanel.SetActive(false);
            quiz1.SetActive(true);
            playerScore1.text = score + "/" + totalQuestion;
            messageDone1.text = "Back";
            StartCoroutine(myCoroutine());
            string quizDone = "done";
            PlayerPrefs.SetString("done", quizDone);
            PlayerPrefs.SetInt("score", score);
            SceneManager.UnloadSceneAsync("Quiz");
            


        }
        else
        {
            questionPanel.SetActive(false);
            quizRetry.SetActive(true);
            messageDone2.text = score + "/" + totalQuestion;
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
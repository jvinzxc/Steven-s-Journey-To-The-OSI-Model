using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuizGameShow : MonoBehaviour
{
    public GameObject tq;
    public GameObject hideMission;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            tq.SetActive(true);
            hideMission.SetActive(false);
        }
    }
}

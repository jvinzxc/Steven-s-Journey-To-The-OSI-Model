using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level3QuizDonee : MonoBehaviour
{
    public GameObject no1;
    public GameObject no2;
    public void Start()
    {
        int l3score = PlayerPrefs.GetInt("l3quizscore");
        if (l3score == 10)
        {
            no1.SetActive(false);
            no2.SetActive(true);
        }
    }
    void Update()
    {

        Start();
    }
}

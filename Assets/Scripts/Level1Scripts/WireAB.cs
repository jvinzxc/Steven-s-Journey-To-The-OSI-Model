using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WireAB : MonoBehaviour
{
    static public WireAB Instance;
    public int switchCount;
    public GameObject gameA;
    public GameObject gameB;
    public GameObject right;
    public GameObject left;
    private int onCount = 0;

    private void Awake()
    {
        Instance = this;


    }
    public void SwitchChange(int points)
    {
        onCount = onCount + points;
        if (onCount == switchCount)
        {
            gameA.SetActive(false);
            gameB.SetActive(true);
            right.SetActive(true);
            left.SetActive(true);
            
        }
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }
    }
}

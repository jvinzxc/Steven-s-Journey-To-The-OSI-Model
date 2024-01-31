using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main : MonoBehaviour
{
    static public Main Instance;
    public int switchCount;
    public GameObject prevLev;
    public GameObject nextLev;
    public GameObject prevCam;
    public GameObject nextCam;
    public GameObject winText;
    public GameObject activator;
    public GameObject bM;
    public GameObject sM;
    private int onCount = 0;
    
    private void Awake()
    {
        Instance = this;
        
        
    }
    public void SwitchChange(int points) {
        onCount = onCount + points;
        if (onCount == switchCount)
        {   
            
            prevCam.SetActive(false);
            prevLev.SetActive(false);
            nextLev.SetActive(true);
            nextCam.SetActive(true);
            activator.SetActive(true);
            bM.SetActive(true);
            sM.SetActive(true);
           
        }
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R)) {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }


    }
}

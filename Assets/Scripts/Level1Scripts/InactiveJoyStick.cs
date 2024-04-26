using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InactiveJoyStick : MonoBehaviour
{
    public GameObject mgame;
    public GameObject joystick;
    public StopJoystick sj;
    public GameObject mgameEnd; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (mgame.activeSelf)
        {
            joystick.SetActive(false);

            if (!joystick.activeSelf)
            {
                Time.timeScale = 0;
                sj.TogglePause();
            }
        }
        if (mgameEnd.activeSelf)
        {
            Time.timeScale = 1;
            sj.TogglePause();
        }
        
    }
}

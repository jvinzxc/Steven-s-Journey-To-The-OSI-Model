using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level3ButtonShow : MonoBehaviour
{
    public GameObject joystick;
    public GameObject button;
    public StopJoystick jstop;


    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            button.SetActive(true);           
        }
    }

    public void Update()
    {
        if (!joystick.activeSelf)
        {
            Time.timeScale = 0;
            jstop.TogglePause();
        }
    }

    public void UnpauseToggle()
    {
        Time.timeScale = 1;
        jstop.TogglePause();
    }
}

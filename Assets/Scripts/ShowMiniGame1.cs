using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowMiniGame1 : MonoBehaviour
{
    public GameObject prevLev;
    public GameObject nextLev;
    public GameObject prevCam;
    public GameObject nextCam;
    public GameObject joystick;
    public GameObject wiremark;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            joystick.SetActive(false);
            prevCam.SetActive(false);
            wiremark.SetActive(false);
            nextLev.SetActive(true);
            nextCam.SetActive(true);
            
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetActiveJoystick : MonoBehaviour
{
    public GameObject joystick;
    public GameObject gameObj1;
    public GameObject gameObj2;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            joystick.SetActive(true);
            gameObj1.SetActive(true);
            gameObj2.SetActive(true);
        }
    }
}

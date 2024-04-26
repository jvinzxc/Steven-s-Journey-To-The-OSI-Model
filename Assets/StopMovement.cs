using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

public class StopMovement : MonoBehaviour
{
    public GameObject joystick;
    public GameObject thisObj;
    public PlayerMovement pm;
    void Start()
    {
        Update();
    }

    // Update is called once per frame
    void Update()
    {
        if (!joystick.gameObject.activeInHierarchy)
        {
           pm.StopMoving();
        }
    }
}

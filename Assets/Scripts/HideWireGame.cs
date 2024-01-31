using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class HideWireGame : MonoBehaviour
{
    public GameObject main;
    public GameObject obj1;
    public GameObject obj2;
    public GameObject obj3;
    public GameObject obj4;
    public GameObject obj5cam;
    public GameObject obj6cam;
    public GameObject obj7jstick;
    public void Start()
    {
        if (main.activeInHierarchy)
        {
            obj1.SetActive(false);
            obj2.SetActive(false);
            obj3.SetActive(false);
            obj4.SetActive(false);
            obj5cam.SetActive(false);
            obj6cam.SetActive(true);
            obj7jstick.SetActive(true);
        }
    }
}

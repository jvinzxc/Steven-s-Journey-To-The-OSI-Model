using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1CollectDestroy : MonoBehaviour
{
    public GameObject obj1;
    public GameObject obj2;
    public GameObject obj3;
    public GameObject obj4;
    public GameObject obj5;


    public GameObject obj6;

    public void Start()
    {
        checkObj1();
    }

    public void Update()
    {
        checkObj1();
    }
    public void obj1Destroy()
    {
        string obj1Collected = "collected";
        PlayerPrefs.SetString("objcollect", obj1Collected);
    }

    public void obj2Destroy()
    {
        string obj2Collected = "collected";
        PlayerPrefs.SetString("objcollect", obj2Collected);
    }

    public void obj3Destroy()
    {
        string obj3Collected = "collected";
        PlayerPrefs.SetString("objcollect", obj3Collected);
    }

    public void obj4Destroy()
    {
        string obj4Collected = "collected";
        PlayerPrefs.SetString("objcollect", obj4Collected);
    }

    public void obj5Destroy()
    {
        string obj5Collected = "collected";
        PlayerPrefs.SetString("objcollect", obj5Collected);
    }

    public void checkObj1()
    {
        string obj1collected2 = PlayerPrefs.GetString("obj1Collected");

        if (obj1collected2.Equals("collected"))
        {
            obj6.SetActive(true);

            if (obj6.activeInHierarchy)
            {
                obj1.SetActive(false);
            }
        }
    }
}

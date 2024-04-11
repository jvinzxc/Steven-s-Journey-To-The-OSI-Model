using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContinueScriptPart : MonoBehaviour
{
    public GameObject c1;
    public GameObject c2;
    public void Start()
    {
        int unlocklvl = PlayerPrefs.GetInt("levelsUnlocked");
        
        if(unlocklvl > 0)
        {
            c1.SetActive(false);
            c2.SetActive(true);


        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QGisActive : MonoBehaviour
{
    public GameObject qgActive;
    public GameObject activatorInactive;
    public GameObject activator;
    public GameObject exMark;
    public QuestionManager qm;
    public void Start()
    {
        
            
            if (qm.score == 10)
            {
                qgActive.SetActive(true);
                if (qgActive.activeInHierarchy)
                {
                    exMark.SetActive(false);
                    activator.SetActive(false);
                    activatorInactive.SetActive(false);
                }
            }     
    }
}

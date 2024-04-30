using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class l3showTask : MonoBehaviour
{
    public GameObject showpanel;
    public GameObject hidedoor;
    public GameObject hidetrigger;
    public GameObject hideblock;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            showpanel.SetActive(true);
            int l3score = PlayerPrefs.GetInt("l3collectedscore");

            if (l3score == 5)
            {
                hideblock.SetActive(false);
                hidedoor.SetActive(false);
                hidetrigger.SetActive(false);
            }
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AdaptivePerformance.VisualScripting;

public class TurnOnPCTrigger : MonoBehaviour
{
    public GameObject turnOnPC;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals("Player"))
        {
            turnOnPC.SetActive(true);

          
        }
    }
   
}

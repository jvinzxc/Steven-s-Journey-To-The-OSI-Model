using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AdaptivePerformance.VisualScripting;

public class TurnOnPCTrigger : MonoBehaviour
{
    public GameObject turnOnPC;
    public GameObject hideJstck;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals("Player"))
        {
            turnOnPC.SetActive(true);
            hideJstck.SetActive(false);
        }
    }
   
}

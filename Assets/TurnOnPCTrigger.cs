using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AdaptivePerformance.VisualScripting;

public class TurnOnPCTrigger : MonoBehaviour
{
    public GameObject turnOnPC;
    public GameObject trigOn;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals("Player"))
        {
            turnOnPC.SetActive(true);
            if (!turnOnPC.activeInHierarchy)
            {
                trigOn.SetActive(true);
            }
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

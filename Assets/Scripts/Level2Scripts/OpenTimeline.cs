using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenTimeline : MonoBehaviour
{
    public GameObject timeline;
    public GameObject trigger;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            timeline.SetActive(true);
            trigger.SetActive(false);
        }
    }
}

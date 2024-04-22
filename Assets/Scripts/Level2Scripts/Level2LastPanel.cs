using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level2LastPanel : MonoBehaviour
{
    public GameObject ShowLastPanel;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            ShowLastPanel.SetActive(true);
        }
    }
}

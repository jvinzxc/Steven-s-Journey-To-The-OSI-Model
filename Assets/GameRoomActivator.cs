using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;
using UnityEngine.UI;

public class GameRoomActivator : MonoBehaviour
{
    public GameObject gameRoomTrigger;
    public GameObject doorAsset;
    public GameObject door;
    public GameObject panel;
    private int collectedItems;
    public Text text;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        
        
        if (collision.CompareTag("Player"))
        {
            panel.SetActive(true);
        }
    }
    public void Update()
    {
        
        text.text = $"Collected Items: {collectedItems}/5 ";
        collectedItems = PlayerPrefs.GetInt("collectedItems");
    }

    public void ItemsCollected()
    {
        if (collectedItems == 5 ) 
        {
            gameRoomTrigger.SetActive(false);
            door.SetActive(false);
            doorAsset.SetActive(false);
            panel.SetActive(false);
        }
    }
}

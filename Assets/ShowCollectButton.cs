using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowCollectButton : MonoBehaviour
{
    public GameObject showButton;
    public GameObject hidejstick;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            showButton.SetActive(true);
            PlayerMovement player = collision.GetComponent<PlayerMovement>();
            
            hidejstick.SetActive(false);
        }
    }
}

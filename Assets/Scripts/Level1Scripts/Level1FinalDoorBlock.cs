using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1FinalDoorBlock : MonoBehaviour
{
    public GameObject check;
    public GameObject fdblock;
    public GameObject fdoor;
    public GameObject panel;
    public GameObject trigger;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            panel.SetActive(true);
            int score = PlayerPrefs.GetInt("score");
            if (score == 10)
            {
                check.SetActive(true);
                fdblock.SetActive(false);
                fdoor.SetActive(false);
                trigger.SetActive(false);
            }

        }
    }
}

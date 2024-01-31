using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Level2PickUpTrigger : MonoBehaviour
{
    public GameObject toCollect;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        toCollect.SetActive(false);
    }
}

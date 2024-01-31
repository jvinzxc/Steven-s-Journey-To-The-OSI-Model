using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class PickUpTrigger : MonoBehaviour
{
    public GameObject thingsToCollect;
    public GameObject Chck;
    public GameObject mark;
    public GameObject fyi;
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            thingsToCollect.SetActive(false);
            mark.SetActive(false);
            Chck.SetActive(true);
            fyi.SetActive(true);
        }
    }    
}

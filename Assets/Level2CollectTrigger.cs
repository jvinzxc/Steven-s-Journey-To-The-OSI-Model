using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level2CollectTrigger : MonoBehaviour
{
    public GameObject toCollect;
    public GameObject OpenRoom;
    public GameObject OpenColl;
    public GameObject CloseRoom;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (toCollect.activeInHierarchy)
            {

                Debug.Log("Active");
            }
            else
            {
                OpenRoom.SetActive(false);
                OpenColl.SetActive(false);
                CloseRoom.SetActive(false); 
                Debug.Log("Inactive");
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriviaTrigger : MonoBehaviour
{
    public GameObject showTrivia;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            showTrivia.SetActive(true);
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

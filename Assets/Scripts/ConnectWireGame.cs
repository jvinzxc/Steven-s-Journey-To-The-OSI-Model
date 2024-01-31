using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using JetBrains.Annotations;

public class ConnectWireGame : MonoBehaviour
{
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.CompareTag("Player"))
        {
            if(SceneManager.GetActiveScene(). buildIndex == 2)
            {
                DontDestroyOnLoad(gameObject);
                SceneManager.LoadScene(3);
            }
            else
            {
                SceneManager.LoadScene(2);
            }
        }
    }
}

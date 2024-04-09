using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpawnBack : MonoBehaviour
{
    public int nextSceneIndex;
    public bool completeScene;
    public Vector3 respawn;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (completeScene)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
                collision.transform.position = respawn;
            }
            else
            {
                SceneManager.LoadScene(nextSceneIndex);
            }
        }
    }

}

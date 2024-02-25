using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavePlayerPosition : MonoBehaviour
{
    public Transform player;
    Vector3 playerPosition;

    void Start()
    {
        if (PlayerPrefs.HasKey("playerStarted"))
        {
            player.position = new Vector3(PlayerPrefs.GetFloat("playerPositionX"), PlayerPrefs.GetFloat("playerPositionY"), PlayerPrefs.GetFloat("playerPositionZ"));
        }
        if (PlayerPrefs.HasKey("playerStarted"))
        {
            PlayerPrefs.SetInt("playerStarted", 1);
            PlayerPrefs.Save();
        }
    }

    // Update is called once per frame
    void Update()
    {
        playerPosition = player.position;
        PlayerPrefs.SetFloat("playerPositionX", playerPosition.x);
        PlayerPrefs.SetFloat("playerPositionY", playerPosition.y);
        PlayerPrefs.SetFloat("playerPositionZ", playerPosition.z);
        PlayerPrefs.Save();
        Debug.Log("X:" + PlayerPrefs.GetFloat("playerPositionX") + " Y:" + PlayerPrefs.GetFloat("playerPositionY") + " Z:" + PlayerPrefs.GetFloat("playerPositionZ"));
    }
}

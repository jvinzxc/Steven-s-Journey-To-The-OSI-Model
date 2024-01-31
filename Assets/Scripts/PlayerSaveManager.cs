using System.IO;
using UnityEngine;
using Unity.VisualScripting;

public class PlayerSaveManager : MonoBehaviour
{
    public PlayerData playerData;
    public Transform player;

    private Vector3 playerPosition;
    private Quaternion playerRotation;

    //bool for loading the data once.
    private bool playerDataLoaded = false;

    void Start()
    {
        if (File.Exists(Application.persistentDataPath + "/playerData.json") && !playerDataLoaded)
        {
            LoadPlayerData();
            playerDataLoaded = true; // Set the flag to true to indicate that data is already loaded
        }
    }

    public void SaveNewPlayerData()
    {
        Vector3 playerNewPos = playerPosition;
        playerNewPos.y = 4f;

        string json = JsonUtility.ToJson(playerData);
        string savePath = Path.Combine(Application.persistentDataPath, "playerData.json");

        // Write the JSON data to a file
        File.WriteAllText(savePath, json);
        Debug.Log("Saved Player Data");
    }

    public void LoadPlayerData()
    {
        string json = File.ReadAllText(Application.persistentDataPath + "/playerData.json");
        playerData = JsonUtility.FromJson<PlayerData>(json);

        if (player != null)
        {
            player.transform.position = playerData.playerPosition;
            player.transform.rotation = playerData.playerRotation;
        }
        Debug.Log("Game Loaded");
    }

    //Call When Saving
    public void SavePlayerData()
    {
        if (player != null)
        {
            playerData.playerPosition = player.transform.position;
            playerData.playerRotation = player.transform.rotation;
        }

        //Save
        string json = JsonUtility.ToJson(playerData);
        string savePath = Path.Combine(Application.persistentDataPath, "playerData.json");
        File.WriteAllText(savePath, json);
        Debug.Log("Saved Player Data");
    }
}

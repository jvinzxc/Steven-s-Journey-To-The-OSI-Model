using System.IO;
using UnityEngine;
using Unity.VisualScripting;
using UnityEngine.SceneManagement;

public class PlayerSaveManagerLevel2 : MonoBehaviour
{
    public SavePlayerLevel2 playerData;
    public Transform player;

    //bool for loading the data once.
    private bool playerDataLoaded = false;



    private void Awake()
    {
        if (!playerDataLoaded && File.Exists(Application.persistentDataPath + "/playerDatal2.json"))
        {
            LoadPlayerData();
            playerDataLoaded = true;

        }
        else
        {
            Debug.Log("File not found!");
            SaveNewPlayerData();
        }
    }
    void Start()
    {
        if (SceneManager.GetActiveScene().name == "Level 2")
        {
            InvokeRepeating("SavePlayerData", -4077.87f, 116.08f);
            Debug.Log("asdasdasds");
        }

    }

    public void SaveNewPlayerData()
    {
        //Declare what you want to save, kunin mo ung coordinates ng gusto mong pag respawnan
        playerData.playerPosition.x = -4077.87f;
        playerData.playerPosition.y = 116.08f;
        playerData.playerPosition.z = 0f;

        //Save
        string json = JsonUtility.ToJson(playerData, true);
        string savePath = Path.Combine(Application.persistentDataPath, "playerDatal2.json");
        File.WriteAllText(savePath, json);
        Debug.Log("Saved New Player Data");
    }

    public void LoadPlayerData()
    {
        string json = File.ReadAllText(Application.persistentDataPath + "/playerDatal2.json");
        playerData = JsonUtility.FromJson<SavePlayerLevel2>(json);

        //declare what you want to load "Use the playerData or any data u want always"
        if (player != null)
        {
            player.position = playerData.playerPosition;
            player.rotation = playerData.playerRotation;
        }
        Debug.Log("Game Loaded");
    }
    //Call When Saving
    public void SavePlayerData()
    {
        if (player != null)
        {
            playerData.playerPosition = player.position;
            playerData.playerRotation = player.rotation;
        }

        //Save
        string json = JsonUtility.ToJson(playerData, true);
        string savePath = Path.Combine(Application.persistentDataPath, "playerDatal2.json");
        File.WriteAllText(savePath, json);
    }
}

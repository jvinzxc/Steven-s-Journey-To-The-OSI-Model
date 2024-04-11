using System.IO;
using UnityEngine;
using Unity.VisualScripting;
using UnityEngine.SceneManagement;

public class PlayerSaveManager : MonoBehaviour
{
    public SavePlayer playerData;
    public Transform player;

    //bool for loading the data once.
    private bool playerDataLoaded = false;


    private void Awake()
    {
        if (!playerDataLoaded && File.Exists(Application.persistentDataPath + "/playerData.json"))
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
        if (SceneManager.GetActiveScene().name == "Level 1")
        {
            InvokeRepeating("SavePlayerData", -109f, -2f);
            Debug.Log("asdasdasds");
        }
        
    }

    public void SaveNewPlayerData()
    {
        //Declare what you want to save, kunin mo ung coordinates ng gusto mong pag respawnan
        playerData.playerPosition.x = -109f;
        playerData.playerPosition.y = -2;
        playerData.playerPosition.z = 0f;

        //Save
        string json = JsonUtility.ToJson(playerData, true);
        string savePath = Path.Combine(Application.persistentDataPath, "playerData.json");
        File.WriteAllText(savePath, json);
        Debug.Log("Saved New Player Data");

        //if may save na or wala
        string snpd = "save!";
        PlayerPrefs.SetString("snpd", snpd);
    }

    public void LoadPlayerData()
    {
        string json = File.ReadAllText(Application.persistentDataPath + "/playerData.json");
        playerData = JsonUtility.FromJson<SavePlayer>(json);

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
        string savePath = Path.Combine(Application.persistentDataPath, "playerData.json");
        File.WriteAllText(savePath, json);
    }
}

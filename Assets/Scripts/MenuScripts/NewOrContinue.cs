using System.Collections;
using System.Collections.Generic;
using Unity.Properties;
using UnityEngine;
using UnityEngine.SceneManagement;
public class NewOrContinue : MonoBehaviour

{
    public GameObject contBtnf;
    public GameObject contBtnt;
    public GameObject mpanel;
    string snpd;
    // Start is called before the first frame update
    void Start()
    {   
        snpd = PlayerPrefs.GetString("snpd");
    }

    public void Message()
    {
        if (snpd.Equals("save!"))
        {
            contBtnf.SetActive(false);
            contBtnt.SetActive(true);
        }
        else
        {
            mpanel.SetActive(true);
        }

    }
    public void GoToLevelLoader()
    {
        string sceneName = "LevelChoices";
        PlayerPrefs.SetString("SceneName", sceneName);
        SceneManager.LoadScene("LoadingScene");
    }
}

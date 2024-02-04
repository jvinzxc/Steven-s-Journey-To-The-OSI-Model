using UnityEngine;
using UnityEngine.SceneManagement;

public class Level7Complete : MonoBehaviour
{
    public GameObject panelComplete, joystick, missionList;
    //Iloload lang ung level choices 
    //Palitan mo nalang kung may ilalagay ka na unlock new level
    //Pwede ka maglagay ng PlayerPrefs to keep track kung ano stage ka na
    //Ingat lang sa bug na kada repeat mo ng level baka mag-add rin siya
    private void OnTriggerEnter2D(Collider2D other){
        if(other.CompareTag("Player")){
            panelComplete.SetActive(true);
            joystick.SetActive(false);
            missionList.SetActive(false);
            Time.timeScale = 0f;
        }
    }
}

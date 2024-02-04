using UnityEngine;
using UnityEngine.SceneManagement;

public class Level4Complete : MonoBehaviour
{
    //Iloload lang ung level choices 
    //Palitan mo nalang kung may ilalagay ka na unlock new level
    //Pwede ka maglagay ng PlayerPrefs to keep track kung ano stage ka na
    //Ingat lang sa bug na kada repeat mo ng level baka mag-add rin siya
    private void OnTriggerEnter2D(Collider2D other){
        if(other.CompareTag("Player")){
            SceneManager.LoadSceneAsync("LevelChoices");
        }
    }
}

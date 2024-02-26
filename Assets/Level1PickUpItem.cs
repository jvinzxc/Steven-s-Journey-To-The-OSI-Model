using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class Level1PickUpItem : MonoBehaviour
{

    [SerializeField] public GameObject[] toCollect;
    [SerializeField] public GameObject[] check;
    [SerializeField] public GameObject[] mark;
    [SerializeField] public GameObject[] fyi;
    
    public TMP_Text text;
    private int collectedItems = 0;
    public void Update()
    {
        CollectedItems();
    }
    

    public void CollectedItems()
    {
       int col = PlayerPrefs.GetInt("collectedItems");
       text.text = "Collected Items: " + col;
       PlayerPrefs.Save();
    }


    public void ToolsCollected()
    {
        for (int i = 4; i < toCollect.Length; i++)
        {
            if (i == 4) 
            {
                toCollect[4].gameObject.SetActive(false);

                for (int j = 4; j < check.Length; j++)
                {
                    check[4].SetActive(true);

                    for (int k = 4; k < mark.Length; k++)
                    {

                        mark[4].SetActive(false);

                        for (int l = 4; l < fyi.Length; l++)
                        {
                            fyi[4].SetActive(true);  
                        }
                    }
                }
            }
        }
        if (collectedItems == 0)
        {
            collectedItems++;
            PlayerPrefs.SetInt("collectedItems", collectedItems);
        }
        else if (collectedItems == 1)
        {
            collectedItems++;
            PlayerPrefs.SetInt("collectedItems", collectedItems);
        }
        else if (collectedItems == 2)
        {
            collectedItems++;
            PlayerPrefs.SetInt("collectedItems", collectedItems);
        }
        else if (collectedItems == 3)
        {
            collectedItems++;
            PlayerPrefs.SetInt("collectedItems", collectedItems);
        }
        else if (collectedItems == 4)
        {
            collectedItems++;
            PlayerPrefs.SetInt("collectedItems", collectedItems);
        }
        else if (collectedItems == 5)
        {
            PlayerPrefs.SetInt("collectedItems", collectedItems);
        }
    }
    public void RJ45Collected()
    {
        for (int i = 3; i < toCollect.Length; i++)
        {
            if (i == 3)
            {
                toCollect[3].gameObject.SetActive(false);

                for (int j = 3; j < check.Length; j++)
                {
                    check[3].SetActive(true);

                    for (int k = 3; k < mark.Length; k++)
                    {

                        mark[3].SetActive(false);

                        for (int l = 3; l < fyi.Length; l++)
                        {
                            fyi[3].SetActive(true);
                        }
                    }
                }
            }
        }
        if (collectedItems == 0)
        {
            collectedItems++;
            PlayerPrefs.SetInt("collectedItems", collectedItems);
        }
        else if (collectedItems == 1)
        {
            collectedItems++;
            PlayerPrefs.SetInt("collectedItems", collectedItems);
        }
        else if (collectedItems == 2)
        {
            collectedItems++;
            PlayerPrefs.SetInt("collectedItems", collectedItems);
        }
        else if (collectedItems == 3)
        {
            collectedItems++;
            PlayerPrefs.SetInt("collectedItems", collectedItems);
        }
        else if (collectedItems == 4)
        {
            collectedItems++;
            PlayerPrefs.SetInt("collectedItems", collectedItems);
        }
        else if (collectedItems == 5)
        {
            PlayerPrefs.SetInt("collectedItems", collectedItems);
        }
    }
    public void CoaxialCollected()
    {
        for (int i = 2; i < toCollect.Length; i++)
        {
            if (i == 2)
            {
                toCollect[2].gameObject.SetActive(false);

                for (int j = 2; j < check.Length; j++)
                {
                    check[2].SetActive(true);

                    for (int k = 2; k < mark.Length; k++)
                    {

                        mark[2].SetActive(false);

                        for (int l = 2; l < fyi.Length; l++)
                        {
                            fyi[2].SetActive(true);
                        }
                    }
                }
            }
        }
        if (collectedItems == 0)
        {
            collectedItems++;
            PlayerPrefs.SetInt("collectedItems", collectedItems);
        }
        else if (collectedItems == 1)
        {
            collectedItems++;
            PlayerPrefs.SetInt("collectedItems", collectedItems);
        }
        else if (collectedItems == 2)
        {
            collectedItems++;
            PlayerPrefs.SetInt("collectedItems", collectedItems);
        }
        else if (collectedItems == 3)
        {
            collectedItems++;
            PlayerPrefs.SetInt("collectedItems", collectedItems);
        }
        else if (collectedItems == 4)
        {
            collectedItems++;
            PlayerPrefs.SetInt("collectedItems", collectedItems);
        }
        else if (collectedItems == 5)
        {
            PlayerPrefs.SetInt("collectedItems", collectedItems);
        }
    }
    public void UnhieldedCollected()
    {
        for (int i = 1; i < toCollect.Length; i++)
        {
            if (i == 1)
            {
                toCollect[1].gameObject.SetActive(false);

                for (int j = 1; j < check.Length; j++)
                {
                    check[1].SetActive(true);

                    for (int k = 1; k < mark.Length; k++)
                    {

                        mark[1].SetActive(false);

                        for (int l = 1; l < fyi.Length; l++)
                        {
                            fyi[1].SetActive(true);
                        }
                    }
                }
            }
        }
        if (collectedItems == 0)
        {
            collectedItems++;
            PlayerPrefs.SetInt("collectedItems", collectedItems);
        }
        else if (collectedItems == 1)
        {
            collectedItems++;
            PlayerPrefs.SetInt("collectedItems", collectedItems);
        }
        else if (collectedItems == 2)
        {
            collectedItems++;
            PlayerPrefs.SetInt("collectedItems", collectedItems);
        }
        else if (collectedItems == 3)
        {
            collectedItems++;
            PlayerPrefs.SetInt("collectedItems", collectedItems);
        }
        else if (collectedItems == 4)
        {
            collectedItems++;
            PlayerPrefs.SetInt("collectedItems", collectedItems);
        }
        else if (collectedItems == 5)
        {
            PlayerPrefs.SetInt("collectedItems", collectedItems);
        }
    }
    public void ShieldedCollected()
    {
        for(int i = 0; i < toCollect.Length; i++)
        {
            if (i == 0)
            {
                toCollect[0].gameObject.SetActive(false);
                
                for (int j = 0; j < check.Length; j++)
                {
                    check[0].SetActive(true);

                    for(int k = 0; k < mark.Length; k++) {

                        mark[0].SetActive(false);

                        for (int l = 0; l < fyi.Length; l++)
                        {
                            fyi[0].SetActive(true);
                        }
                    }
                }
            }
        }
        if (collectedItems == 0)
        {
            collectedItems++;
            PlayerPrefs.SetInt("collectedItems", collectedItems);
        }
        else if (collectedItems == 1)
        {
            collectedItems++;
            PlayerPrefs.SetInt("collectedItems", collectedItems);
        }
        else if (collectedItems == 2)
        {
            collectedItems++;
            PlayerPrefs.SetInt("collectedItems", collectedItems);
        }
        else if (collectedItems == 3)
        {
            collectedItems++;
            PlayerPrefs.SetInt("collectedItems", collectedItems);
        }
        else if (collectedItems == 4)
        {
            collectedItems++;
            PlayerPrefs.SetInt("collectedItems", collectedItems);
        }
        else if (collectedItems == 5)
        {
            PlayerPrefs.SetInt("collectedItems", collectedItems);
        }
    }
}

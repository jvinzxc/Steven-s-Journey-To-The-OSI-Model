using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;
using UnityEngine.UI;

public class Level2PickUpItem : MonoBehaviour
{
     public GameObject[] toCollect;
     public GameObject[] check;
     public GameObject[] mark;


    public Text text;
    private int collectedItems2 = 0;

    public void Update()
    {
        CollectedItems();
    }

    public void CollectedItems()
    {
        int  col = PlayerPrefs.GetInt("collectedItems2");
        text.text = "Collected Items: " + col;
        PlayerPrefs.Save();
    }

    public void Collect5()
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
                    }
                }
            }
        }
        if (collectedItems2 == 0)
        {
            collectedItems2++;
            PlayerPrefs.SetInt("collectedItems2", collectedItems2);
        }
        else if (collectedItems2 == 1)
        {
            collectedItems2++;
            PlayerPrefs.SetInt("collectedItems2", collectedItems2);
        }
        else if (collectedItems2 == 2)
        {
            collectedItems2++;
            PlayerPrefs.SetInt("collectedItems2", collectedItems2);
        }
        else if (collectedItems2 == 3)
        {
            collectedItems2++;
            PlayerPrefs.SetInt("collectedItems2", collectedItems2);
        }
        else if (collectedItems2 == 4)
        {
            collectedItems2++;
            PlayerPrefs.SetInt("collectedItems2", collectedItems2);
        }
        else if (collectedItems2 == 5)
        {
            PlayerPrefs.SetInt("collectedItems2", collectedItems2);
        }
    }
    public void Collect4()
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
                    }
                }
            }
        }
        if (collectedItems2 == 0)
        {
            collectedItems2++;
            PlayerPrefs.SetInt("collectedItems2", collectedItems2);
        }
        else if (collectedItems2 == 1)
        {
            collectedItems2++;
            PlayerPrefs.SetInt("collectedItems2", collectedItems2);
        }
        else if (collectedItems2 == 2)
        {
            collectedItems2++;
            PlayerPrefs.SetInt("collectedItems2", collectedItems2);
        }
        else if (collectedItems2 == 3)
        {
            collectedItems2++;
            PlayerPrefs.SetInt("collectedItems2", collectedItems2);
        }
        else if (collectedItems2 == 4)
        {
            collectedItems2++;
            PlayerPrefs.SetInt("collectedItems2", collectedItems2);
        }
        else if (collectedItems2 == 5)
        {
            PlayerPrefs.SetInt("collectedItems2", collectedItems2);
        }
    }
    public void Collect3()
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
                    }
                }
            }
        }
        if (collectedItems2 == 0)
        {
            collectedItems2++;
            PlayerPrefs.SetInt("collectedItems2", collectedItems2);
        }
        else if (collectedItems2 == 1)
        {
            collectedItems2++;
            PlayerPrefs.SetInt("collectedItems2", collectedItems2);
        }
        else if (collectedItems2 == 2)
        {
            collectedItems2++;
            PlayerPrefs.SetInt("collectedItems2", collectedItems2);
        }
        else if (collectedItems2 == 3)
        {
            collectedItems2++;
            PlayerPrefs.SetInt("collectedItems2", collectedItems2);
        }
        else if (collectedItems2 == 4)
        {
            collectedItems2++;
            PlayerPrefs.SetInt("collectedItems2", collectedItems2);
        }
        else if (collectedItems2 == 5)
        {
            PlayerPrefs.SetInt("collectedItems2", collectedItems2);
        }
    }
    public void Collect2()
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
                    }
                }
            }
        }
        if (collectedItems2 == 0)
        {
            collectedItems2++;
            PlayerPrefs.SetInt("collectedItems2", collectedItems2);
        }
        else if (collectedItems2 == 1)
        {
            collectedItems2++;
            PlayerPrefs.SetInt("collectedItems2", collectedItems2);
        }
        else if (collectedItems2 == 2)
        {
            collectedItems2++;
            PlayerPrefs.SetInt("collectedItems2", collectedItems2);
        }
        else if (collectedItems2 == 3)
        {
            collectedItems2++;
            PlayerPrefs.SetInt("collectedItems2", collectedItems2);
        }
        else if (collectedItems2 == 4)
        {
            collectedItems2++;
            PlayerPrefs.SetInt("collectedItems2", collectedItems2);
        }
        else if (collectedItems2 == 5)
        {
            PlayerPrefs.SetInt("collectedItems2", collectedItems2);
        }
    }
    public void Collect1()
    {
        for (int i = 0; i < toCollect.Length; i++)
        {
            if (i == 0)
            {
                toCollect[0].gameObject.SetActive(false);

                for (int j = 0; j < check.Length; j++)
                {
                    check[0].SetActive(true);

                    for (int k = 0; k < mark.Length; k++)
                    {
                        mark[0].SetActive(false);
                    }
                }
            }
        }
        if (collectedItems2 == 0)
        {
            collectedItems2++;
            PlayerPrefs.SetInt("collectedItems2", collectedItems2);
        }
        else if (collectedItems2 == 1)
        {
            collectedItems2++;
            PlayerPrefs.SetInt("collectedItems2", collectedItems2);
        }
        else if (collectedItems2 == 2)
        {
            collectedItems2++;
            PlayerPrefs.SetInt("collectedItems2", collectedItems2);
        }
        else if (collectedItems2 == 3)
        {
            collectedItems2++;
            PlayerPrefs.SetInt("collectedItems2", collectedItems2);
        }
        else if (collectedItems2 == 4)
        {
            collectedItems2++;
            PlayerPrefs.SetInt("collectedItems2", collectedItems2);
        }
        else if (collectedItems2 == 5)
        {
            PlayerPrefs.SetInt("collectedItems2", collectedItems2);
        }
    }
}

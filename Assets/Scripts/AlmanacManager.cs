using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AlmanacManager : MonoBehaviour
{
    //level buttons
    public Button levelbutton1;
    public Button levelbutton2;
    public Button levelbutton3;
    public Button levelbutton4;
    public Button levelbutton5;
    public Button levelbutton6;
    public Button levelbutton7;

    //level 1 buttons on almanac
    string l1collected = PlayerPrefs.GetString("l1collect");
    string scollected = PlayerPrefs.GetString("scollect");
    string uscollected = PlayerPrefs.GetString("uscollect");
    string ccollected = PlayerPrefs.GetString("ccollect");
    string rcollected = PlayerPrefs.GetString("rcollect");
    string fcollected = PlayerPrefs.GetString("fcollect");

    public Button stp;
    public Button utp;
    public Button coaxial;
    public Button rj45;
    public Button fiberOptic;


    //level 2 buttons on almanac
    string l2collected = PlayerPrefs.GetString("l2collect");
    string octcollected = PlayerPrefs.GetString("octcollect");
    string hexcollected = PlayerPrefs.GetString("hexcollect");
    string niccollected = PlayerPrefs.GetString("niccollect");
    string swcollected = PlayerPrefs.GetString("swcollect");
    string maccollected = PlayerPrefs.GetString("maccollect");

    public Button oct;
    public Button hex;
    public Button nic;
    public Button sw;
    public Button mac;

    //level 3 buttons on almanac


    public void Start()
    {
        Update();
    }
    public void Update()
    {
        Level1CollectManager();
        Level2CollectManager();
    }

    public void Level1CollectManager()
    {
        if (l1collected.Equals("l1collect"))
        {
            levelbutton1.interactable = true;
        }
        else
        {
            levelbutton1.interactable = false;
        }

        if (scollected.Equals("scollect"))
        {
            stp.interactable = true;
        }
        else
        {
            stp.interactable = false;
        }

        if (uscollected.Equals("uscollect"))
        {
            utp.interactable = true;
        }
        else
        {
            utp.interactable = false;
        }

        if (ccollected.Equals("ccollect"))
        {
            coaxial.interactable = true;
        }
        else
        {
            coaxial.interactable = false;
        }

        if (rcollected.Equals("rcollect"))
        {
           rj45.interactable = true;
        }
        else
        {
            rj45.interactable = false;
        }

        if (fcollected.Equals("fcollect"))
        {
            fiberOptic.interactable = true;
        }
        else
        {
            fiberOptic.interactable = false;
        }
    }

    public void Level2CollectManager()
    {
        if (l2collected.Equals("l2collect"))
        {
            levelbutton2.interactable = true;
        }
        else
        {
            levelbutton2.interactable = false;
        }

        if (octcollected.Equals("octcollect"))
        {
            oct.interactable = true;
        }
        else
        {
            oct.interactable = false;
        }

        if (hexcollected.Equals("hexcollect"))
        {
            hex.interactable = true;
        }
        else
        {
            hex.interactable = false;
        }

        if (niccollected.Equals("niccollect"))
        {
            nic.interactable = true;
        }
        else
        {
            nic.interactable = false;
        }

        if (swcollected.Equals("swcollect"))
        {
            sw.interactable = true;
        }
        else
        {
            sw.interactable = false;
        }

        if (maccollected.Equals("maccollect"))
        {
            mac.interactable = true;
        }
        else
        {
            mac.interactable = false;
        }
    }


}

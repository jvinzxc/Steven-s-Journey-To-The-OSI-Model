using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Level1AlmanacCollect : MonoBehaviour
{
    public Button s;
    public Button u;
    public Button c;
    public Button r;
    public Button f;
    public Button l1;
    public void Start()
    {
        Update();
    }
    public void Level1Collect()
    {
        string l1collect = "l1collect";
        PlayerPrefs.SetString("l1collect", l1collect);
    }
    public void ShieldedCollected()
    {
        string scollect = "scollect";
        PlayerPrefs.SetString("scollect", scollect);
    }

    public void UnshieldedCollected()
    {
        string uscollect = "uscollect";
        PlayerPrefs.SetString("scollect", uscollect);
    }

    public void CoaxialCollected()
    {
        string ccollect = "ccollect";
        PlayerPrefs.SetString("scollect", ccollect);
    }
    public void Rj45Collected()
    {
        string rcollect = "rcollect";
        PlayerPrefs.SetString("scollect", rcollect);
    }
    public void FiberOpticCollected()
    {
        string fcollect = "fcollect";
        PlayerPrefs.SetString("scollect", fcollect);
    }
    public void Update()
    {
        string scl = PlayerPrefs.GetString("scollect");
        string uscl = PlayerPrefs.GetString("uscollect");
        string ccl = PlayerPrefs.GetString("ccollect");
        string rcl = PlayerPrefs.GetString("rcollect");
        string fcl = PlayerPrefs.GetString("fcollect");
        string l1c = PlayerPrefs.GetString("l1collect");

        if (l1c.Equals("l1collect"))
        {
            l1.interactable = true;
        }
        else
        {
            l1.interactable = false;
        }
        if (scl.Equals("scollect"))
        {
            s.interactable = true;
        }
        else
        {
            s.interactable = false;
        }

        if (uscl.Equals("uscollect"))
        {
            u.interactable = true;
        }
        else
        {
            u.interactable = false;
        }

        if (ccl.Equals("ccollect"))
        {
            c.interactable = true;
        }
        else
        {
            c.interactable = false;
        }

        if (rcl.Equals("rcollect"))
        {
            r.interactable = true;
        }
        else
        {
            r.interactable = false;
        }

        if (fcl.Equals("fcollect"))
        {
            f.interactable = true;
        }
        else
        {
            f.interactable = false;
        }
    }
}

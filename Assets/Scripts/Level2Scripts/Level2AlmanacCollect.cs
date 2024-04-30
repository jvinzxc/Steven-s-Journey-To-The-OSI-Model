using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Level2AlmanacCollect : MonoBehaviour
{
    public Button o;
    public Button h;
    public Button n;
    public Button s;
    public Button m;
    public Button l2;
    public void Start()
    {
        Update();
    }
    public void Level1Collect()
    {
        string l2collect = "l2collect";
        PlayerPrefs.SetString("l2collect", l2collect);
    }
    public void octalCollected()
    {
        string octcollect = "octcollect";
        PlayerPrefs.SetString("octcollect", octcollect);
    }

    public void hexCollected()
    {
        string hexcollect = "hexcollect";
        PlayerPrefs.SetString("hexcollect", hexcollect);
    }

    public void nicCollected()
    {
        string niccollect = "niccollect";
        PlayerPrefs.SetString("niccollect", niccollect);
    }
    public void switchCollected()
    {
        string swcollect = "swcollect";
        PlayerPrefs.SetString("swcollect", swcollect);
    }
    public void macCollected()
    {
        string maccollect = "maccollect";
        PlayerPrefs.SetString("maccollect", maccollect);
    }
    public void Update()
    {
        string oct = PlayerPrefs.GetString("octcollect");
        string hex = PlayerPrefs.GetString("hexcollect");
        string nic = PlayerPrefs.GetString("niccollect");
        string sw = PlayerPrefs.GetString("swcollect");
        string mac = PlayerPrefs.GetString("maccollect");
        string l2c = PlayerPrefs.GetString("l2collect");

        if (l2c.Equals("l1collect"))
        {
            l2.interactable = true;
        }
        else
        {
            l2.interactable = false;
        }
        if (oct.Equals("octcollect"))
        {
            o.interactable = true;
        }
        else
        {
            o.interactable = false;
        }

        if (hex.Equals("hexcollect"))
        {
            h.interactable = true;
        }
        else
        {
            h.interactable = false;
        }

        if (nic.Equals("niccollect"))
        {
            n.interactable = true;
        }
        else
        {
            n.interactable = false;
        }

        if (sw.Equals("swcollect"))
        {
            s.interactable = true;
        }
        else
        {
            s.interactable = false;
        }

        if (mac.Equals("maccollect"))
        {
            m.interactable = true;
        }
        else
        {
            m.interactable = false;
        }
    }
}

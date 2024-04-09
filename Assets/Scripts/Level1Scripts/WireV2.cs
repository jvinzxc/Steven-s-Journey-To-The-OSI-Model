using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WireV2 : MonoBehaviour
{
    private List<GameObject> gameObjList = new List<GameObject>();

    private void Update()
    {
        InsertGameObj(1, gameObject);
    }

    void InsertGameObj(int index, GameObject obj)
    {
        gameObjList.Insert(index, obj);
    }
}

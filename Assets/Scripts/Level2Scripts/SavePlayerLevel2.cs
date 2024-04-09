using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class SavePlayerLevel2
{
    public Vector3 playerPosition;
    public Quaternion playerRotation;

    public SavePlayerLevel2(Vector3 playerPosition, Quaternion playerRotation)
    {
        this.playerPosition = playerPosition;
        this.playerRotation = playerRotation;
    }
}

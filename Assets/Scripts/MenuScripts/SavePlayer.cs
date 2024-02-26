using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavePlayer
{
    public Vector3 playerPosition;
    public Quaternion playerRotation;

    public SavePlayer(Vector3 playerPosition, Quaternion playerRotation)
    {
        this.playerPosition = playerPosition;
        this.playerRotation = playerRotation;
    }
}

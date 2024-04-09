
using UnityEngine;

public class PlayerDataLevel2
{
    public Vector3 playerPosition;
    public Quaternion playerRotation;

    public PlayerDataLevel2(Vector3 playerPosition, Quaternion playerRotation)
    {
        this.playerPosition = playerPosition;
        this.playerRotation = playerRotation;
    }
}

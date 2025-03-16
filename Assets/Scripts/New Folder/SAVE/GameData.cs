using UnityEngine;

[System.Serializable]
public class GameData
{
    //saved values for testing purposes
    public float time;
    public Vector3 playerPosition;
    public GameData()
    {
        this.time = 0;
        playerPosition = Vector3.zero;
    }
}

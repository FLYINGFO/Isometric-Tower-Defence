using System.Data;
using UnityEngine;

public class VeryTemporary : MonoBehaviour, IData
{
    public float xX;
    public float yY;
    public float zZ;
    public void Update()
    {
        if ( transform.position.x != xX || transform.position.y != yY || transform.position.z != zZ)
        {
            Debug.Log(xX + "->" + transform.position.x + ", " + yY + "->" + transform.position.y + ", " + zZ + "->" + transform.position.z);
        }
        xX = transform.position.x;
        yY = transform.position.y;
        zZ = transform.position.z;
    }
    public void LoadData(GameData data)
    {
        this.transform.position = data.playerPosition;
    }
    public void SaveData(ref GameData data)
    {
        data.playerPosition = this.transform.position;
        data.time = Time.time;
    }
}

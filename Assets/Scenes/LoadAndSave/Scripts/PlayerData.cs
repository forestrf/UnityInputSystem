using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{
    public int level = 3;
    public int health = 40;    
    public float[] position;    // public Vector3 position;

    // Constructor
    public PlayerData(Player player)
    {
        level = player.level;
        health = player.health;

        position = new float[3];
        position[0] = player.position.x;
        position[1] = player.position.y;
        position[2] = player.position.z;
    }

}

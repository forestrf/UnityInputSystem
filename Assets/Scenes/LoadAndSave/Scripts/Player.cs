using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    public int level = 3;
    public int health = 40;
    public Vector3 position;

    SaveLoadControls controls;

    void Awake()
    {
        controls = new SaveLoadControls();

        controls.SaveLoadData.Save.performed += ctx => Save();

        controls.SaveLoadData.Load.performed += ctx => Load();
    }

    void Save()         // Save data
    {
        SaveSystem.SavePlayer(this);
        Debug.Log("Player data saved");
    }

    void Load()         // Load data
    {
        PlayerData playerData = SaveSystem.LoadPlayer();
        level = playerData.level;
        health = playerData.health;
        position.x = playerData.position[0];
        position.y = playerData.position[1];
        position.z = playerData.position[2];
        Debug.Log("Player data loaded");
    }

    void OnEnable()
    {
        controls.SaveLoadData.Enable();
    }

    void OnDisable()
    {
        controls.SaveLoadData.Disable();
    }
}

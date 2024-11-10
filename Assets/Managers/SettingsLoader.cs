using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsLoader : MonoBehaviour
{
    public Vector2 SpawnYVelocity ;
    public Vector2 SpawnXVelocity; 
    public float JumpMult;
    
    void Awake()
    {
        GameSettings.SpawnYVelocity = SpawnYVelocity;
        GameSettings.SpawnXVelocity = SpawnXVelocity;
        GameSettings.JumpMult = JumpMult;
    }

}

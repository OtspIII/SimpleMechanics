using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public static bool ButtonDown(GameInputs i)
    {
        if (i == GameInputs.SpawnFace) return Input.GetKeyDown(KeyCode.Z);
        else if (i == GameInputs.SpawnVamp) return Input.GetKeyDown(KeyCode.X);
        else if (i == GameInputs.SpawnCube) return Input.GetKeyDown(KeyCode.C);
        else
        {
            Debug.Log("ATTEMPTED UNSET BUTTON: " + i);
            return false;
        }
    }
    
    public static bool Button(GameInputs i)
    {
        if (i == GameInputs.SpawnFace) return Input.GetKey(KeyCode.Z);
        else if (i == GameInputs.SpawnVamp) return Input.GetKey(KeyCode.X);
        else if (i == GameInputs.SpawnCube) return Input.GetKey(KeyCode.C);
        else
        {
            Debug.Log("ATTEMPTED UNSET BUTTON: " + i);
            return false;
        }
    }
    
    public static bool ButtonUp(GameInputs i)
    {
        if (i == GameInputs.SpawnFace) return Input.GetKeyUp(KeyCode.Z);
        else if (i == GameInputs.SpawnVamp) return Input.GetKeyUp(KeyCode.X);
        else if (i == GameInputs.SpawnCube) return Input.GetKeyUp(KeyCode.C);
        else
        {
            Debug.Log("ATTEMPTED UNSET BUTTON: " + i);
            return false;
        }
    }
}

public enum GameInputs
{
    None=0,
    SpawnFace=1,
    SpawnVamp=2,
    SpawnCube=3,
}
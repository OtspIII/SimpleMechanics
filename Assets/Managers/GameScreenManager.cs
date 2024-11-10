using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScreenManager : MonoBehaviour
{
    public FallingObjectScript Prefab;
    public List<FallingObjectScript> AllFallers;

    private void Awake()
    {
        God.GSM = this;
    }

    void Update()
    {
        if (InputManager.ButtonDown(GameInputs.SpawnFace))
        {
            FallingObjectScript f = Instantiate(Prefab, Vector3.zero, Quaternion.identity);
            f.Setup(ObjectTypes.Face);
            AllFallers.Add(f);
            foreach (FallingObjectScript all in AllFallers)
                all.Jump(GameSettings.JumpMult);
            f.Jump(1);
        }
        if (InputManager.ButtonDown(GameInputs.SpawnVamp))
        {
            FallingObjectScript f = Instantiate(Prefab, Vector3.zero, Quaternion.identity);
            f.Setup(ObjectTypes.Vamp);
            AllFallers.Add(f);
            foreach (FallingObjectScript all in AllFallers)
                all.Jump(GameSettings.JumpMult);
            f.Jump(1);
        }
        if (InputManager.ButtonDown(GameInputs.SpawnCube))
        {
            FallingObjectScript f = Instantiate(Prefab, Vector3.zero, Quaternion.identity);
            f.Setup(ObjectTypes.Cube);
            AllFallers.Add(f);
            foreach (FallingObjectScript all in AllFallers)
                all.Jump(GameSettings.JumpMult);
            f.Jump(1);
        }

    }
}
